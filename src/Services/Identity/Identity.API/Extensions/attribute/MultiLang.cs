using Identity.API.ResourcesCus;

namespace System
{
    public static class MultiLang
    {
        public static string Tag(string strResource)
        {
            return strResource;
        }
        /// <summary>
        /// Resource.Culture = CultureInfo.GetCultureInfo("zh-CN");
        /// </summary>
        /// <param name="strResource"></param>
        /// <returns></returns>
        public static string GetResourceString(string strResource)
        {
            try
            {
                if (!String.IsNullOrEmpty(strResource) && Resource.ResourceManager.GetString(strResource) != null)
                    return Resource.ResourceManager.GetString(strResource).ToString();
                else
                    return strResource;
            }
            catch (Exception)
            {
                return strResource;
            }
        } 
    }
}
