using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NetCoreSample.Framework.Abstract;
using System.Net;
using System.Net.Http;

namespace NetCoreSample.Api.Filters
{
    public sealed class GlobalExceptionFilterAttribute : ExceptionFilterAttribute
    {
        #region ctor & member

        readonly ILoggingService loggingService;

        public GlobalExceptionFilterAttribute(ILoggingService loggingService)
        {
            this.loggingService = loggingService;
        }

        #endregion

        public override void OnException(ExceptionContext context)
        {
            var methodName = $"{ context.RouteData.Values["controller"].ToString()}.{ context.RouteData.Values["action"].ToString()}";
            var message = $"{nameof(GlobalExceptionFilterAttribute)}.{nameof(OnException)}";

            loggingService.LogError(methodName, message, context.Exception);

            var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent("Serviste dahili bir hata oluştu. Lütfen sistem yöneticinize başvurun."),
                ReasonPhrase = "Dahili Sunucu Hatası. Lütfen sistem yöneticinize başvurun."
            };

            context.Result = new JsonResult(response);

            base.OnException(context);
        }
    }
}