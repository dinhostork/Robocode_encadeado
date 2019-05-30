/**
 * Copyright (c) 2001-2019 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * https://robocode.sourceforge.io/license/epl-v10.html
 */
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package net.sf.robocode.dotnet.repository.root;

@net.sf.jni4net.attributes.ClrType
public class DllRootHelper extends system.Object {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected DllRootHelper(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    protected DllRootHelper() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native static void Open();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native static void Close();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)[LSystem/String;")
    public native static java.lang.String[] findItems(java.lang.String dllPath);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lnet/sf/robocode/repository/IRobotItem;)Lnet/sf/robocode/repository/RobotType;")
    public native static net.sf.robocode.repository.RobotType GetRobotType(net.sf.robocode.repository.IRobotItem robotItem);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lnet/sf/robocode/repository/IRobotItem;)LSystem/String;")
    public native static java.lang.String GetDllFileName(net.sf.robocode.repository.IRobotItem robotItem);
    
    public static system.Type typeof() {
        return net.sf.robocode.dotnet.repository.root.DllRootHelper.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        net.sf.robocode.dotnet.repository.root.DllRootHelper.staticType = staticType;
    }
    //</generated-proxy>
}