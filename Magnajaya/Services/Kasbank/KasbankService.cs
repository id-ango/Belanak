using Magnajaya.Data;
using Magnajaya.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magnajaya.Services.Kasbank
{
    
   
        public interface IKasbankService
        {
            Task<List<CbBank>> Get();
            Task<CbBank> Get(int id);
            Task<CbBank> Add(CbBank cbBank);
            Task<CbBank> Update(CbBank cbBank);
            Task<CbBank> Delete(int id);
        }


        public class KasbankService : IKasbankService
        {
        private readonly ApplicationDbContext _context;

        public KasbankService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CbBank> Add(CbBank cbBank)
        {
            string test = cbBank.Kode.ToUpper();
            var cekFirst = _context.Banks.Where(x=>x.Kode == test).ToList() ;
            if (cekFirst.Count == 0)
            {
                cbBank.Saldo = cbBank.SldAwal;
                cbBank.KSaldo = cbBank.KsldAwal;
                cbBank.Kode = test;

                _context.Banks.Add(cbBank);
                await _context.SaveChangesAsync();
                return cbBank;
            }
            else
                cbBank.NmBank = "Kode Bank sudah ada!!";
                return cbBank;
        }

        public async Task<CbBank> Delete(int id)
        {
            var bank = await _context.Banks.FindAsync(id);
            _context.Banks.Remove(bank);
            await _context.SaveChangesAsync();
            return bank;
        }

        public async Task<List<CbBank>> Get()
        {
            return await _context.Banks.ToListAsync();
        }

        public async Task<CbBank> Get(int id)
        {
            var bank = await _context.Banks.FindAsync(id);
            return bank;
        }

        public async Task<CbBank> Update(CbBank cbBank)
        {
            string test = cbBank.Kode.ToUpper();
            cbBank.Saldo = cbBank.Saldo+cbBank.SldAwal;
            cbBank.KSaldo = cbBank.KSaldo+cbBank.KsldAwal;
            cbBank.Kode = test;
            _context.Entry(cbBank).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return cbBank;
        }
    }
        
   
}
