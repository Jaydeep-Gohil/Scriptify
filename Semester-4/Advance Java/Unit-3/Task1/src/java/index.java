/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */

import java.io.IOException;
import java.io.PrintWriter;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;


/**
 *
 * @author LENOV
 */
@WebServlet(urlPatterns = {"/index"})
public class index extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        try (PrintWriter out = response.getWriter()) {
            /* TODO output your page here. You may use following sample code. */
            out.println("<!DOCTYPE html>");
            out.println("<html>");
            out.println("<head>");
            out.println("<title>Servlet index</title>");
            out.println("</head>");
            out.println("<body>");
            String unm=request.getParameter("usernm");
            String pwd=request.getParameter("pwd");
            if(unm.equals("admin") && pwd.equals("123")){
                out.println("<form action='' method='POST'>"); 
                out.println("<table>");
                out.println("<tr><td>First Name :</td><td><input type='text' name='fName' required></td></tr>");
                out.println("<tr><td>Last Name :</td><td><input type='text' name='lName' required></td></tr>");
                out.println("<tr><td>Department :</td><td><input type='text' name='Dept' required></td></tr>");
                out.println("<tr><td>Course :</td><td><input type='text' name='Cou' required></td></tr>");
                out.println("<tr><td colspan='2' align='center'><input type='submit' value='Submit'></td></tr>");
                out.println("</table>");
                out.println("</form>");
            }
            out.println("</body>");
            out.println("</html>");
        }
    }
}

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    


    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */


   