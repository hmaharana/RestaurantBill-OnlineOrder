using AdminApi.DTO.App.Order;
using AdminApi.Models;
using AdminApi.Models.App.Order;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AdminApi.Controllers
{
    public class POSOrderItemController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<POSOrderItem> _pOSOrderItemRepo;
        public POSOrderItemController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<POSOrderItem> pOSOrderItemRepo
                               )
        {
            _config = config;
            _context = context;
            _pOSOrderItemRepo = pOSOrderItemRepo;

        }
        

    }
}
