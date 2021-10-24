using AutoMapper;
using ForestInfoApi.Dtos;
using ForestInfoApi.Interfaces;
using ForestInfoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForestInfoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisionsController : ControllerBase
    {
        private readonly IDivisionData _divisionData;
        private readonly IMapper _mapper;

        public DivisionsController(IDivisionData divisionData, IMapper mapper)
        {
            _divisionData = divisionData ?? throw new ArgumentNullException(nameof(divisionData));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<DivisionReadDto>> GetDivisions()
        {
            var divisionItems = _divisionData.GetAll();
            return Ok(_mapper.Map<IEnumerable<DivisionReadDto>>(divisionItems));
        }

        [HttpGet("{id}",Name = "GetDivisionById")]
        public ActionResult<DivisionReadDto> GetDivisionById(int id)
        {
            var divisionItem = _divisionData.GetById(id);
            if (divisionItem != null)
            {
                return Ok(_mapper.Map<DivisionReadDto>(divisionItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<DivisionReadDto> CreateDivision(DivisionCreateDto divisionCreateDto)
        {
            var divisionModel = _mapper.Map<Division>(divisionCreateDto);
            _divisionData.Add(divisionModel);

            var division = _mapper.Map<DivisionReadDto>(divisionModel);
            return CreatedAtRoute(nameof(GetDivisionById), new { Id = division.DivisionCode }, division);
        }

        [HttpDelete("{id}", Name = "DeleteDivision")]
        public ActionResult<DivisionReadDto> DeleteDivision(int id)
        {
            var division = _divisionData.Delete(id);
            return Ok(_mapper.Map<DivisionReadDto>(division));
        }

    }
}
