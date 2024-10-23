// <auto-generated/>
#pragma warning disable
using Microsoft.Extensions.DependencyInjection;

namespace Internal.Generated.WolverineHandlers
{
    // START: WidgetUsingMessageHandler4925106
    public class WidgetUsingMessageHandler4925106 : Wolverine.Runtime.Handlers.MessageHandler
    {
        private readonly Microsoft.Extensions.DependencyInjection.IServiceScopeFactory _serviceScopeFactory;

        public WidgetUsingMessageHandler4925106(Microsoft.Extensions.DependencyInjection.IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }



        public override System.Threading.Tasks.Task HandleAsync(Wolverine.Runtime.MessageContext context, System.Threading.CancellationToken cancellation)
        {
            using var serviceScope = _serviceScopeFactory.CreateScope();
            
            /*
            * Concrete type System.Collections.Generic.IEnumerable<CoreTests.Codegen.IWidget> is not public, so requires service location
            */
            var widgetIEnumerable = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<System.Collections.Generic.IEnumerable<CoreTests.Codegen.IWidget>>(serviceScope.ServiceProvider);
            // The actual message body
            var widgetUsingMessage = (CoreTests.Codegen.WidgetUsingMessage)context.Envelope.Message;

            
            // The actual message execution
            CoreTests.Codegen.WidgetUsingMessageHandler.Handle(widgetUsingMessage, widgetIEnumerable);

            return System.Threading.Tasks.Task.CompletedTask;
        }

    }

    // END: WidgetUsingMessageHandler4925106
    
    
}
