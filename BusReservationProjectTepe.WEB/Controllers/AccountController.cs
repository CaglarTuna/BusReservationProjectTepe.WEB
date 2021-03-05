using AutoMapper;
using BusReservationProjectTepe.Core.Models;
using BusReservationProjectTepe.Core.Services;
using BusReservationProjectTepe.Data;
using BusReservationProjectTepe.Service.Services;
using BusReservationProjectTepe.WEB.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservationProjectTepe.WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly RoleManager<AppUserRoles> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        public AccountController(IUserService userService,IMapper mapper, AppDbContext db,RoleManager<AppUserRoles> roleManager, UserManager<AppUser> userManager)
        {
            _userService = userService;
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
            _mapper = mapper;
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(UserDto userDto)
        {
            await _userService.AddAsync(_mapper.Map<AppUser>(userDto));
            return Ok("ok");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserDto userDto)
        {
            if (_userService.Where(x => x.Email == userDto.Email).Result.Any())
            {
                var currentUser = _userService.Where(x => x.Email == userDto.Email).Result.FirstOrDefault();
                var roles = _roleManager.Roles.ToList();
                //_userManager.AddToRoleAsync(currentUser,"Admin");
                return RedirectToAction("Index","Home");
            }
            return BadRequest();
        }
    }
}
