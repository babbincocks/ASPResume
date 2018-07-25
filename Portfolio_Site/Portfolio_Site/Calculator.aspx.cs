using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio_Site
{
    public partial class Calculator : System.Web.UI.Page
    {

        double total = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //ViewState["Total"] = total;
                if (!Page.IsPostBack)
                {
                    txtResult.Text = "0";
                }
                else
                {
                    //txtResult.Text = ViewState["Total"].ToString();
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length > 0)
                {
                    if (ViewState["Big"] == null)
                    {
                        if (ViewState["Total"] != null)
                        {
                            total = (double)ViewState["Total"] + double.Parse(txtInput.Text);
                        }
                        else
                        {
                            total = double.Parse(txtInput.Text);
                        }


                        ViewState["Total"] = total;

                        double c = double.Parse(ViewState["Total"].ToString());
                        if (c > double.MaxValue - 10)
                        {
                            txtResult.Text = "Error: Number too large. Reset to 0.";
                            ViewState["Total"] = 0;
                            ViewState["Big"] = 1;
                            total = 0;
                        }
                        else
                        {
                            txtResult.Text = total.ToString();
                        }
                    }

                    else
                    {
                        total = double.Parse(txtInput.Text);
                        txtResult.Text = total.ToString();
                        ViewState["Big"] = null;
                        ViewState["Total"] = total;

                    }
                }
                else
                {
                    Response.Write("You gotta put something in, you obtuse pancake.");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length > 0)
                {
                    if (ViewState["Big"] == null)
                    {

                        if (ViewState["Total"] != null)
                        {
                            total = (double)ViewState["Total"] - double.Parse(txtInput.Text);
                        }
                        else
                        {
                            total = 0 - double.Parse(txtInput.Text);
                        }
                        ViewState["Total"] = total;
                        double c = double.Parse(ViewState["Total"].ToString());
                        if (c < double.MinValue + 10)
                        {
                            txtResult.Text = "Error: Number too large. Reset to 0.";
                            ViewState["Total"] = 0;
                            ViewState["Big"] = 1;
                            total = 0;
                        }
                        else
                        {
                            txtResult.Text = total.ToString();
                        }
                    }

                    else
                    {
                        total = 0 - double.Parse(txtInput.Text);
                        txtResult.Text = total.ToString();
                        ViewState["Big"] = null;
                        ViewState["Total"] = total;

                    }
                }
                else
                {
                    Response.Write("You gotta put something in, you obtuse pancake.");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length > 0)
                {
                    if (ViewState["Big"] == null)
                    {
                        if (ViewState["Total"] != null)
                        {
                            total = (double)ViewState["Total"] * double.Parse(txtInput.Text);
                        }
                        else
                        {
                            total = double.Parse(txtInput.Text);
                        }
                        ViewState["Total"] = total;
                        double c = double.Parse(ViewState["Total"].ToString());
                        if (c > double.MaxValue - 10 || c < double.MinValue + 10)
                        {
                            txtResult.Text = "Error: Number too large. Reset to 0.";
                            ViewState["Big"] = 1;
                            ViewState["Total"] = 0;
                            total = 0;
                        }
                        else
                        {
                            txtResult.Text = total.ToString();
                        }

                    }

                    else
                    {
                        total = double.Parse(txtInput.Text);
                        txtResult.Text = total.ToString();
                        ViewState["Big"] = null;
                        ViewState["Total"] = total;

                    }
                }
                else
                {
                    Response.Write("You gotta put something in, you obtuse pancake.");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtInput.Text.Length > 0)
                {
                    if (ViewState["Big"] == null)
                    {
                        if (ViewState["Total"] != null)
                        {
                            total = (double)ViewState["Total"] / double.Parse(txtInput.Text);
                            if ((double)ViewState["Total"] == 0 && double.Parse(txtInput.Text) == 0)
                            {
                                Response.Write("Nice try, you foot.");
                                total = 0;
                                ViewState["Total"] = 0;
                            }
                        }
                        else
                        {
                            total = double.Parse(txtInput.Text);
                        }
                        ViewState["Total"] = total;
                        double c = double.Parse(ViewState["Total"].ToString());
                        if (c > double.MaxValue - 10)
                        {
                            txtResult.Text = "Error: Number too large. Reset to 0.";
                            ViewState["Big"] = 1;
                            ViewState["Total"] = 0;
                            total = 0;
                        }
                        else
                        {
                            txtResult.Text = total.ToString();
                        }
                    }
                    else
                    {
                        total = double.Parse(txtInput.Text);
                        txtResult.Text = total.ToString();
                        ViewState["Big"] = null;
                        ViewState["Total"] = total;

                    }
                }
                else
                {
                    Response.Write("You gotta put something in, you obtuse pancake.");
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void pnlCalc_PreRender(object sender, EventArgs e)
        {

        }
    }
}