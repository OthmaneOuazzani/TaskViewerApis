using Microsoft.AspNetCore.Mvc;
using TaskViewerApis.Interfaces;
using TaskViewerApis.Models;

namespace TaskViewerApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaController : ControllerBase
    {
        private readonly ILaService _laService;
        private readonly ILogger<TaskController> _logger;



        public LaController(ILaService laService, ILogger<TaskController> logger)
        {
            _laService = laService;
            _logger = logger;
        }


        [HttpGet("Las")]
        public async Task<IActionResult> GetAllLas()
        {
            return Ok(await _laService.GetAllLas());
        }


        [HttpGet("LaById")]
        public async Task<IActionResult> GetLa(string id)
        {
            return Ok(await _laService.GetLa(id));
        }

        [HttpGet("page")]
        public async Task<IActionResult> GetLaPage(
     [FromQuery] int page,
     [FromQuery] int pageSize,
     [FromQuery] string? projectSpace,
     [FromQuery] string? assignedPerson,
     [FromQuery] string? decPsa,
     [FromQuery] string? plmId,
     [FromQuery] string? title,
     [FromQuery] string? leader,
     [FromQuery] string? managementState,
     [FromQuery] string? supervisor,
     [FromQuery] string? service,
     [FromQuery] string? toDoBy,
     [FromQuery] string? satisfiedByEcoState,
     [FromQuery] string? satisfiedByObjectId,
     [FromQuery] string? satisfiedByRevision,
     [FromQuery] string? satisfiedByEco,
     [FromQuery] string? contextType,
     [FromQuery] string? state,
     [FromQuery] string? coteRal,
     [FromQuery] string? coteRt,
     [FromQuery] string? createdBetweenStart,
     [FromQuery] string? createdBetweenEnd,
     [FromQuery] string? releasedBetweenStart,
     [FromQuery] string? releasedBetweenEnd,
     [FromQuery] string? customerDateStart,
     [FromQuery] string? customerDateEnd,
     [FromQuery] string? canceledBetweenStart,
     [FromQuery] string? canceledBetweenEnd,
     [FromQuery] string? supplierDateStart,
     [FromQuery] string? supplierDateEnd,
     [FromQuery] string? agreedBetweenStart,
     [FromQuery] string? agreedBetweenEnd,
     [FromQuery] string? satisfiedByType,
     [FromQuery] string? projectPackage,
     [FromQuery] string? expectedConf,
     [FromQuery] string? errors,
     [FromQuery] string? linkedDocument,
     [FromQuery] string? expectedConfTitle,
     [FromQuery] string? context
 )
        {
            return Ok(await _laService.GetLaPage(
                page,
                pageSize,
                projectSpace,
                assignedPerson,
                decPsa,
                plmId,
                title,
                leader,
                managementState,
                supervisor,
                service,
                toDoBy,
                satisfiedByEcoState,
                satisfiedByObjectId,
                satisfiedByRevision,
                satisfiedByEco,
                contextType,
                state,
                coteRal,
                coteRt,
                createdBetweenStart,
                createdBetweenEnd,
                releasedBetweenStart,
                releasedBetweenEnd,
                customerDateStart,
                customerDateEnd,
                canceledBetweenStart,
                canceledBetweenEnd,
                supplierDateStart,
                supplierDateEnd,
                agreedBetweenStart,
                agreedBetweenEnd,
                satisfiedByType,
                projectPackage,
                expectedConf,
                errors,
                linkedDocument,
                expectedConfTitle,
                context
            ));
        }

    }
}