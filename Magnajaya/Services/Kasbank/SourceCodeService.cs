using Magnajaya.Data;
using Magnajaya.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magnajaya.Services.Kasbank
{
    
   
        public interface ISourceCodeService
        {
            Task<List<CbSrccd>> Get();
            Task<CbSrccd> Get(int id);
            Task<CbSrccd> Add(CbSrccd cbBank);
            Task<CbSrccd> Update(CbSrccd cbBank);
            Task<CbSrccd> Delete(int id);

        Task<List<CbGrp>> GetSrc();

        }


        public class SourceCodeService : ISourceCodeService
        {
        private readonly ApplicationDbContext _context;

        public SourceCodeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CbSrccd> Add(CbSrccd cbBank)
        {
            string test = cbBank.SrcCode.ToUpper();
            var cekFirst = _context.CbCodes.Where(x=>x.SrcCode == test).ToList() ;
            if (cekFirst.Count == 0)
            {
               
                cbBank.SrcCode = test;

                _context.CbCodes.Add(cbBank);
                await _context.SaveChangesAsync();
                return cbBank;
            }
            else
                cbBank.NamaSrc = "Kode Source sudah ada!!";
                return cbBank;
        }

        public async Task<CbSrccd> Delete(int id)
        {
            var bank = await _context.CbCodes.FindAsync(id);
            _context.CbCodes.Remove(bank);
            await _context.SaveChangesAsync();
            return bank;
        }

        public async Task<List<CbSrccd>> Get()
        {
            return await _context.CbCodes.ToListAsync();
        }

        public async Task<List<CbGrp>> GetSrc()
        {
            return await _context.CbGroups.ToListAsync();
        }
        public async Task<CbSrccd> Get(int id)
        {
            var bank = await _context.CbCodes.FindAsync(id);
            return bank;
        }

        public async Task<CbSrccd> Update(CbSrccd cbBank)
        {
            string test = cbBank.SrcCode.ToUpper();
            
            cbBank.SrcCode = test;
            _context.Entry(cbBank).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return cbBank;
        }
    }
        
   
}
