/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package webservice;

import beans.WebServiceSessionBean;
import javax.ejb.EJB;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;

/**
 *
 * @author Poslovni
 */
@WebService(name = "service")
public class Service {
    
    @EJB
    private WebServiceSessionBean webServiceSessionBean;

    /**
     * Web service operation
     * @param a
     * @param b
     * @return a + b
     */
    @WebMethod(operationName = "add")
    public double add(@WebParam(name = "a") double a, @WebParam(name = "b") double b) {
        return webServiceSessionBean.add(a, b);
    }

    /**
     * Web service operation
     * @param a
     * @param b
     * @return a - b
     */
    @WebMethod(operationName = "sub")
    public double sub(@WebParam(name = "a") double a, @WebParam(name = "b") double b) {
        return webServiceSessionBean.sub(a, b);
    }

    /**
     * Web service operation
     * @param a
     * @param b
     * @return a * b
     */
    @WebMethod(operationName = "mult")
    public double mult(@WebParam(name = "a") double a, @WebParam(name = "b") double b) {
        return webServiceSessionBean.mult(a, b);
    }

    /**
     * Web service operation
     * @param a
     * @param b
     * @return a / b
     */
    @WebMethod(operationName = "div")
    public double div(@WebParam(name = "a") double a, @WebParam(name = "b") double b) {
        return webServiceSessionBean.div(a, b);
    }
    
}
