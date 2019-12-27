using Magnajaya.Data;
using Magnajaya.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magnajaya.Services.Kasbank
{
    
   
        public interface ITransDetailService
        {
            Task<List<CbTransH>> Get();
            Task<CbTransH> Get(int id);
            Task<CbTransH> Add(CbTransH cbBank);
            Task<CbTransH> Update(CbTransH cbBank);
            Task<CbTransH> Delete(int id);
     
     
    }


        public class TransDetailService : ITransDetailService
        {
        private readonly ApplicationDbContext _context;

        public TransDetailService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CbTransH> Add(CbTransH cbBank)
        {
            string test = cbBank.Docno.ToUpper();
            var cekFirst = _context.CbTransHs.Where(x=>x.Docno == test).ToList() ;
            if (cekFirst.Count == 0)
            {
                ;
                cbBank.Docno = test;

                _context.CbTransHs.Add(cbBank);
                await _context.SaveChangesAsync();
                return cbBank;
            }
            else
                cbBank.Keterangan = "No. Bukti sudah ada!!";
                return cbBank;
        }

        public async Task<CbTransH> Delete(int id)
        {
            var bank = await _context.CbTransHs.FindAsync(id);
            _context.CbTransHs.Remove(bank);
            await _context.SaveChangesAsync();
            return bank;
        }

        public async Task<List<CbTransH>> Get()
        {
                    
            return await _context.CbTransHs.OrderByDescending(x =>x.Tanggal).ToListAsync();
        }

        public async Task<CbTransH> Get(int id)
        {
            var bank = await _context.CbTransHs.FindAsync(id);
            return bank;
        }

       
       
        public async Task<CbTransH> Update(CbTransH cbBank)
        {
            string test = cbBank.Kode.ToUpper();
          
            cbBank.Kode = test;
            _context.Entry(cbBank).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return cbBank;
        }
    }
        
   
}
