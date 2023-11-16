using Microsoft.AspNetCore.Mvc;

namespace VueRedirectProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RedirectController : ControllerBase
    {

        [HttpPost("Receive")]
        public IActionResult Receive([FromForm] AnswerModel answerModel)
        {
            var url = "http://testhazirsatis.hstmobil.com.tr:8081/paymentresult";
            var queryString = $"orderId={answerModel.orderId}&paymentId={answerModel.paymentId}";
            //answerModel to querystring
            return Redirect($"{url}?{queryString}");
        }
    }   
}
