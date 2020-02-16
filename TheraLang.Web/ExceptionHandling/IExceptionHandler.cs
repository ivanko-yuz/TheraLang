using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TheraLang.Web.ExceptionHandling
{
    public interface IExceptionHandler
    {
        Task Handle(ExceptionContext exceptionContext);
    }
}