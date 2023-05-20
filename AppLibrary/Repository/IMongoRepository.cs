﻿using AppLibrary.Core.Entities;
using System.Linq.Expressions;

namespace AppLibrary.Repository
{
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {

        Task<IEnumerable<TDocument>> GetAll();

        Task<TDocument> GetById(string Id);

        Task InsertDocument(TDocument document);

        Task UpdateDocument(TDocument document);

        Task DeleteById(string Id);

        Task<PaginationEntity<TDocument>> PaginationBy(
            Expression<Func<TDocument,bool>> filterExpression,
            PaginationEntity<TDocument> pagination
        );

        Task<PaginationEntity<TDocument>> PaginationByFilter(
           PaginationEntity<TDocument> pagination
       );
    }
}