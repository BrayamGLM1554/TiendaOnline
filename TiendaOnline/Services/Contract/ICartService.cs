using TiendaOnline.Models.Dto;

namespace TiendaOnline.Services.Contract
{
    public interface ICartService
    {
        Task<ResponseDto> GetCartByUserIdAsync(string userid);
        Task<ResponseDto> UpsertCartAsync(CartDto cartDto);
        Task<ResponseDto> RemoveFromCartAsync(int cartDetailsId);
        Task<ResponseDto> ApplyCouponAsync(CartDto cartDto);
        Task<ResponseDto> EmailCart(CartDto cartDto);
    }
}
