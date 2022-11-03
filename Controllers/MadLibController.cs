using Microsoft.AspNetCore.Mvc;

namespace APIMadLib.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    [HttpGet]
    [Route("madlibchallenge/{adjective}/{animal}/{action1}/{verb}/{food}/{color}/{verb2}/{item}/{number}/{feeling}")]

    public string madlibchall(string adjective, string animal, string action1, string verb, string food, string color, string verb2, string item, string number, string feeling)
    {
        // return "hi";
        return $"It was a {adjective} day and you notice a {animal} which happens to be your favorite animal there. However you notice the animal starts to {action1} and the cage is open! Thinking quickly you decide to {verb} but unexpectedly ran into a person holding {food} spilling all over your {color} shirt. Without thinking about it you start {verb2}. Heading the other direction you didnt notice the {item} so you ran into it and fell but when you look up you notice {number} workers running towards the {animal}. Breathing a sigh of relief you feel {feeling} as you realize the crazy day is over.";
    }

    [HttpGet]
    [Route("test/{adjective}/{animal}/{action}")]
    public string testing(string adjective, string animal, string action)
    {
        return $"{adjective} and {animal} and {action}";
    }
}
