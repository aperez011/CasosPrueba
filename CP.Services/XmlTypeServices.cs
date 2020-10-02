using System;
using System.Collections.Generic;
using System.Text;
using CP.Entity;
using CP.Core.Interfaces;
using CP.Data;
using Microsoft.Extensions.Configuration;
using System.Linq.Expressions;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CP.Services
{
    public class XmlTypeServices : IXmlTypeServices
    {
        private readonly DataContext _context;
        private readonly IConfiguration _conf;
        private readonly ILogger<XmlTypeServices> _logger;

        public XmlTypeServices(DataContext context, IConfiguration conf, ILogger<XmlTypeServices> logger)
        {
            _context = context;
            _conf = conf;
            _logger = logger;
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
        
        public async Task Insert(XmlType entity)
        {
            try
            {
                _context.XmlTypes.Add(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw ex;
            }
        }
        public async Task Delete(Guid gid)
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
