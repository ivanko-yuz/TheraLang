using System;
using System.Collections.Generic;

namespace TheraLang.Web.ExceptionHandling.ExceptionHandlingOptions
{
    public class ExceptionHandlerOptions
    {
        private readonly IDictionary<Type, ExceptionResponseOptions> _exceptionResponse;
        public string ContentType { get; set; } = "application/json";

        public ExceptionResponseOptions DefaultOptionsForUnhandled { get; set; } =
            ExceptionResponseOptions.GetProductionDefault();

        public ExceptionResponseOptions DefaultOptionsForHandled { get; set; } =
            ExceptionResponseOptions.GetProductionDefault();

        public IReadOnlyDictionary<Type, ExceptionResponseOptions> ExceptionResponse =>
            _exceptionResponse as IReadOnlyDictionary<Type, ExceptionResponseOptions>;

        public ExceptionHandlerOptions()
        {
            _exceptionResponse = new Dictionary<Type, ExceptionResponseOptions>();
        }

        public void Map<TException>(Action<ExceptionResponseOptions> responseOptionsConfig)
        {
            var responseOptions = new ExceptionResponseOptions();
            responseOptionsConfig.Invoke(responseOptions);
            _exceptionResponse.Add(typeof(TException), responseOptions);
        }
    }
}