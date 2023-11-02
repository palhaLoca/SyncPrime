using Dapper;
using SyncPrime.Domain.Models;
using SyncPrime.Infrastructure.Data.DBFactory;
using System;
using System.Collections.Generic;

namespace SyncPrime.Domain
{
    public class Repository : IRepository
    {

        private readonly DbSession _session;
        public Repository(DbSession session)
        {
            _session = session;
        }
        public IEnumerable<LineModel> GetLines()
            => _session.Connection.Query<LineModel>("SELECT * FROM CAD_LINES");


        public void Insert(LineModel line)
        {
            var random = new Random();
            _session.Connection.Execute(@"INSERT INTO CAD_LINES
                                               (LAYER ,START_PT_X ,START_PT_Y ,END_PT_X ,END_PT_Y ,CREATED_AT) 
                                        VALUES (@layer , @startPtX, @startPtY, @endPtX, @endPtY, @createdAt)"
                                        , line);
        }

    }
}
