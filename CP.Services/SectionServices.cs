using CP.Core.Interfaces;
using CP.Data;
using CP.Entity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CP.Services
{
    public class SectionServices : ISectionServices
    {
        private readonly DataContext _context;
        private readonly ILogger<SectionServices> _logger;

        public SectionServices(DataContext context, ILogger<SectionServices> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<Section> FindBy(Expression<Func<Section, bool>> condition)
        {
            try
            {
                var sections = _context.Sections.Where(condition);

                return sections;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw ex;
            }
        }

        public IEnumerable<Section> GetAll()
        {
            try
            {
                var sections = _context.Sections.Select(c => c);

                return sections;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw ex;
            }
        }

        public Section GetByGID(Guid gid)
        {
            try
            {
                var section = _context.Sections.FirstOrDefault(s => s.GID == gid);

                return section;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw ex;
            }
        }

        public async Task Insert(Section entity)
        {
            try
            {
                var result = _context.Sections.Add(entity);
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
            try
            {
                Section _sec = _context.Sections.FirstOrDefault(c => c.GID == gid);

                _context.Sections.Remove(_sec);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw ex;
            }
        }
    }
}
