using Backend_Nybetong.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Nybetong.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanDeliveryController : ControllerBase
    {

        public readonly IPlanDelivery _planDelivery; 
        public PlanDeliveryController(IPlanDelivery planDelivery)
        {
            _planDelivery = planDelivery;
        }

    

        [HttpGet("/Authorizations")]
        public async Task<IActionResult> AsyncGetAuthorizations()
        {
            var authorizations = await _planDelivery.AsyncGetAuthorizations();
            if (authorizations == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, authorizations);
        }


        [HttpGet("/Companies")]
        public async Task<IActionResult> AsyncGetCompanies()
        {
            var companies = await _planDelivery.AsyncGetCompanies();
            if (companies == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, companies);
        }

        [HttpGet("/CompanyTypes")]
        public async Task<IActionResult> AsyncGetCompanyTypes()
        {
            var companyTypes = await _planDelivery.AsyncGetCompanyTypes();
            if (companyTypes == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, companyTypes);
        }


        [HttpGet("/ConcreteTypes")]
        public async Task<IActionResult> AsyncGetConcreteTypes()
        {
            var concreteTypes = await _planDelivery.AsyncGetConcreteTypes();
            if (concreteTypes == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, concreteTypes);
        }
        [HttpGet("/ContactCategories")]
        public async Task<IActionResult> AsyncGetContactCategories()
        {
            var contactCategories = await _planDelivery.AsyncGetContactCategories();
            if (contactCategories == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, contactCategories);
        }

        [HttpGet("/ContactInformations")]
        public async Task<IActionResult> AsyncGetContactInformations()
        {
            var contactInformations = await _planDelivery.AsyncGetContactInformations();
            if (contactInformations == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, contactInformations);
        }
        [HttpGet("/Factories")]
        public async Task<IActionResult> AsyncGetFactories()
        {
            var factories = await _planDelivery.AsyncGetFactories();
            if (factories == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, factories);
        }
        [HttpGet("/Halls")]
        public async Task<IActionResult> AsyncGetHalls()
        {
            var halls = await _planDelivery.AsyncGetHalls();
            if (halls == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, halls);
        }
        //[HttpGet]
        //public async Task<IActionResult> AsyncGetLitteras()
        //{
        //    var litteras = await _planDelivery.AsyncGetLitteras();
        //    if (litteras == null)
        //    {
        //        return StatusCode(StatusCodes.Status404NotFound, "not found");
        //    }
        //    return StatusCode(StatusCodes.Status200OK, litteras);
        //}

        [HttpGet("/PlanDeliveries")]
        public async Task<IActionResult> AsyncGetPlanDeliveries()
        {
            var planDeliveries = await _planDelivery.AsyncGetPlanDeliveries();
            if (planDeliveries == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, planDeliveries);
        }
        [HttpGet("/ProductCategories")]
        public async Task<IActionResult> AsyncGetProductCategories()
        {
            var productCategories = await _planDelivery.AsyncGetProductCategories();
            if (productCategories == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, productCategories);
        }
        [HttpGet("/ProjectContents")]
        public async Task<IActionResult> AsyncGetProjectContents()
        {
            var projectContent = await _planDelivery.AsyncGetProjectContents();
            if (projectContent == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, projectContent);
        }
        [HttpGet("/Projects")]
        public async Task<IActionResult> AsyncGetProjects()
        {
            var projects = await _planDelivery.AsyncGetProjects();
            if (projects == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, projects);
        }
        [HttpGet("/Rolls")]
        public async Task<IActionResult> AsyncGetRolls()
        {
            var rolls = await _planDelivery.AsyncGetRolls();
            if (rolls == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, rolls);
        }
        [HttpGet("/Unit")]
        public async Task<IActionResult> AsyncGetUnits()
        {
            var units = await _planDelivery.AsyncGetUnits();
            if (units == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, units);
        }
        [HttpGet("/Users")]
        public async Task<IActionResult> AsyncGetUsers()
        {
            var users = await _planDelivery.AsyncGetUsers();
            if (users == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, users);
        }
    }
}
