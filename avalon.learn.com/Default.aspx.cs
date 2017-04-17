using log4net;
using System;
using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            List<int> li = new List<int>();
            li.Add(1);

            int a = li[2];
        }
        catch (Exception ex)
        {
            var logger = LogManager.GetLogger(typeof(_Default));
            if (logger.IsDebugEnabled)
            {
                logger.Debug("what's up", ex);
            }
        }
    }
}