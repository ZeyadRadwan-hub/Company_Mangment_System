using AutoMapper;
using CompanyMangmentSystem.DTOs;
using CompanyMangmentSystem.Models;
using CompanyMangmentSystem.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CompanyMangmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public DepartmentController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<DepartmentDTO> Create([FromBody] DepartmentDTO dto)
        {
            var x = _mapper.Map<Department>(dto);
            await _unitOfWork.DepartmentUnit.AddAsync(x);
            await _unitOfWork.SaveAsync();

            return dto;
        }

        [HttpGet]
        public async Task<List<DepartmentResponeDTO>> GetAll()
        {
            var x = await _unitOfWork.DepartmentUnit.GetAll();
            var respone = _mapper.Map<List<DepartmentResponeDTO>>(x);
            return respone;
        }

        [HttpGet("{id:int}")]
        public async Task<DepartmentResponeDTO> GetById(int id)
        {
            var x = await _unitOfWork.DepartmentUnit.Get(id);
            var respone = _mapper.Map<DepartmentResponeDTO>(x);
            return respone;
        }

        [HttpPut("{id:int}")]//not work///
        public IActionResult Update([FromBody]DepartmentDTO dto)
        {
            var x = _mapper.Map<Department>(dto);
             _unitOfWork.DepartmentUnit.Update(x);
             _unitOfWork.SaveAsync();
            return NoContent();
        }

        [HttpDelete]//not work////
        public IActionResult Delete(int id)
        {
            _unitOfWork.DepartmentUnit.Delete(id);
            _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}
