using System;
using System.Collections.Generic;
using System.Text;
using CP.Entity;
using CP.Core.Interfaces;
using CP.Data;
using Microsoft.Extensions.Configuration;
using System.Linq.Expressions;

namespace CP.Services
{
    public class XmlTypeServices : IXmlTypeServices
    {
        private readonly DataContext _context;
        private readonly IConfiguration _conf;

        public XmlTypeServices(DataContext context, IConfiguration conf)
        {
            _context = context;
            _conf = conf;
        }

        public IEnumerable<XmlType> GetAll()
        {
            throw new NotImplementedException();
        }
        public XmlType GetByGID(Guid guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<XmlType> FindBy(Expression<Func<XmlType, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public void Delete(XmlType entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(XmlType entity)
        {
            throw new NotImplementedException();
        }

        public void _TestConnection()
        {
            try
            {
                var xmlType = new XmlType()
                {
                    GID = Guid.NewGuid(),
                    IsActive = true,
                    LogDate = DateTime.Now,
                    Name = "Test 1",
                    Order = 1
                };
                
                _context.XmlTypes.Add(xmlType);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
