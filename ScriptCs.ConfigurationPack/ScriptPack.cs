using ScriptCs;
using ScriptCs.Contracts;

namespace ScriptCs.ConfigurationPack
{
    public class ScriptPack : IScriptPack
    {
        IScriptPackContext IScriptPack.GetContext()
        {
            //Return the ScriptPackContext to be used in your scripts
            return new Configx();
        }

        void IScriptPack.Initialize(IScriptPackSession session)
        {
            //Here you can perform initialization like pass using statements 
            //and references by using the session object's two methods:

            //AddReference
            //Use this method to add library references that need to be 
            //available in your script. After the script pack is loaded, 
            //the specified references will be available for use 
            //without any code inside the script.

            //ImportNamespace
            //This method can import namespaces for use in your scripts to help 
            //keep user's scripts clean and simple.

            session.AddReference("System.Configuration");
            session.ImportNamespace("System.Configuration");
        }

        void IScriptPack.Terminate()
        {
            //Cleanup any resources here
        }
    }
}
