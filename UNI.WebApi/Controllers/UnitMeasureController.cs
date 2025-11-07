using Microsoft.AspNetCore.Mvc;
using UNI.Services;

namespace UNI.WebApi

{
    [Route("api/[controller]")]
    public class UnitMeasureController : ControllerBase
    {
        private readonly IServiceManager serviceManager;
        public UnitMeasureController( IServiceManager service)
        {
            serviceManager = service;
        }


        [HttpPost]
        public async Task<IActionResult> CreateUnitMeasure([FromBody] UnitMeasureCreateDto unitMeasureCreateDto)
        {

            unitMeasureCreateDto = await serviceManager.UnitMeasureService.CreateUnitMeasureDto(unitMeasureCreateDto);

            return StatusCode(StatusCodes.Status201Created, unitMeasureCreateDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUnitMeasure()
        {

            List<UnitMeasureCreateDto> categoryCreates= await serviceManager.UnitMeasureService.GetAllUnitMeasure();

            return StatusCode(StatusCodes.Status200OK, categoryCreates);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUnitMeasure(int id)
        {

            bool categoryDelete = await serviceManager.UnitMeasureService.DeleteUnitMeasureById(id);

            return StatusCode(StatusCodes.Status200OK, categoryDelete);
        }
            
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] UnitMeasureCreateDto createDto)
        {

            UnitMeasureCreateDto categoryUpdate = await serviceManager.UnitMeasureService.UpdateUnitMeasure(id, createDto);

            return StatusCode(StatusCodes.Status200OK, categoryUpdate);
        }
    }
}
