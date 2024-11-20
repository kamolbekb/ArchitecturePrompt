using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Room;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;

public class RoomsController : ApiController
{
    private readonly IRoomService _roomService;
}