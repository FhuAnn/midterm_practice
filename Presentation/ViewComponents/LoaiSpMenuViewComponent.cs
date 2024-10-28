using Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using Presentation.Repository;
namespace Presentation.ViewComponents
{
    public class LoaiSpMenuViewComponent :ViewComponent
    { 
        private readonly ILoaiSpRepository _loaiSpRepository;
        public LoaiSpMenuViewComponent(ILoaiSpRepository loaiSpRepository)
        {
            _loaiSpRepository = loaiSpRepository;
        }
        public IViewComponentResult Invoke()
        {
            var loaisp = _loaiSpRepository.GetAllLoaiSp().OrderBy(x => x.Loai); 
            return View(loaisp);
        }
    }
}
