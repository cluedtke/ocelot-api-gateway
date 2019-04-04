using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ledger.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ledger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        // GET api/transactions
        [HttpGet]
        public ActionResult<IEnumerable<Transaction>> Get()
        {
            return Ok(_transactions);
        }

        // GET api/transactions?userId={userId}
        [HttpGet("~/api/users/{userId:guid}/transactions")]
        public ActionResult<IEnumerable<Transaction>> GetByUser([FromRoute]Guid userId)
        {
            return Ok(_transactions.Where(x => x.UserId == userId));
        }

        static readonly Transaction[] _transactions = new[] {
            new Transaction()
            {
                ProductId = Guid.Parse("ef29fc61-abcc-4ac1-9c8c-e5e17b266868"),
                UserId = Guid.Parse("539bf338-e5de-4fc4-ac65-4a91324d8111"),
                OccuredAt = DateTime.Now,
                PriceAtPointInTime = 36,
                Quantity = 5,
                Total = 180
            },
            new Transaction()
            {
                ProductId = Guid.Parse("d91d2019-e642-4b00-8b10-2bf07c383787"),
                UserId = Guid.Parse("6b2c4788-e1d5-4ef4-8edf-e7d57e31bf4f"),
                OccuredAt = DateTime.Now,
                PriceAtPointInTime = 36,
                Quantity = 5,
                Total = 180
            }
        };
    }
}
