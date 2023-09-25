/*
 * Use Of Reflection 
 * 
 * 
 * 
 * 
 * public partial class 
 * {
 *      private void btnapply_click(object sender, EventArgs e)
 *      {
 *          string typeName = tb_type.text;
 *          Type t = Type.GetType(typeName);
 *          
 *          MethodInfo[] methods = t.GetMethods();
 *          foreach(MethodInfo methodInfo in methods)
 *          {
 *              lstMethodList.Items.Add(methodInfo.Name);
 *          }
 *      }
 * }
*/ 