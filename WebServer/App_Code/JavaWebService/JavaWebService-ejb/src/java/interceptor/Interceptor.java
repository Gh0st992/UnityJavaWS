/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package interceptor;

import javax.interceptor.AroundInvoke;
import javax.interceptor.InvocationContext;

/**
 *
 * @author Poslovni
 */
public class Interceptor {
    
    @AroundInvoke
    public Object intercept(InvocationContext context) throws Exception {
        Object[] params = context.getParameters();

        for(int i = 0; i < params.length; i++) {
            if((int) params[i] <= 0) {
                params[i] = 0;
            }
        }
        
        Object result = context.proceed();
        return result;
    }
    
}
