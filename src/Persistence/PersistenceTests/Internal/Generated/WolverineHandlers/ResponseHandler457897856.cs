// <auto-generated/>
#pragma warning disable

namespace Internal.Generated.WolverineHandlers
{
    // START: ResponseHandler457897856
    public class ResponseHandler457897856 : Wolverine.Runtime.Handlers.MessageHandler
    {


        public override System.Threading.Tasks.Task HandleAsync(Wolverine.Runtime.MessageContext context, System.Threading.CancellationToken cancellation)
        {
            // The actual message body
            var response = (PersistenceTests.Marten.Response)context.Envelope.Message;

            
            // The actual message execution
            PersistenceTests.Marten.ResponseHandler.Handle(response);

            return System.Threading.Tasks.Task.CompletedTask;
        }

    }

    // END: ResponseHandler457897856
    
    
}
