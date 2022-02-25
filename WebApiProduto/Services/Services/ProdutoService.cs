using Domain;
using Repository.Interface;
using Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Services.Services
{
    public class ProdutoService : IProdutoService
    {

        private readonly IProdutoRepository _produtoRepository;//colocar injecao dependencia


        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<ProdutoDto> ListarProdutoService()
        {
            try
            {
                return _produtoRepository.ListarProdutoRepository();
            }
            catch (Exception ex)
            {
                throw new Exception($"ERROR: {ex.Message}");//conferir onde colocar exception
            }
        }

        public bool CriarProdutoService(ProdutoDto produto)
        {
            try
            {
                return _produtoRepository.CriarProdutoRepository(produto);
            }
            catch (Exception ex)
            {
                throw new Exception($"ERROR: {ex.Message}");//conferir onde colocar exception
            }
        }

        public bool EditarProdutoService( ProdutoDto produto)
        {
            try
            {
                return _produtoRepository.EditarProdutoRepository(produto);
            }
            catch (Exception ex)
            {
                throw new Exception($"ERROR: {ex.Message}");//conferir onde colocar exception
            }
        }

        public bool ExcluirProdutoService(ProdutoDto produto)
        {
            try
            {
                return _produtoRepository.ExcluirProdutoRepository(produto);
            }
            catch (Exception ex)
            {
                throw new Exception($"ERROR: {ex.Message}");//conferir onde colocar exception
            }
        }
    }
}
