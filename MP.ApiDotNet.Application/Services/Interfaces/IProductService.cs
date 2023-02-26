using System;
using MP.ApiDotNet.Application.DTOs;

namespace MP.ApiDotNet.Application.Services.Interfaces
{
	public interface IProductService
	{
        Task<ResultService<ProductDTO>> CreateAsync(ProductDTO productDTO);
        //Task<ResultService<ICollection<ProductDTO>>> GetAsync();
        //Task<ResultService<ProductDTO>> GetByIdAsync(int id);
        //Task<ResultService> UpdateAsync(ProductDTO productDTO);
        //Task<ResultService> DeleteAsync(int id);
    }
}

