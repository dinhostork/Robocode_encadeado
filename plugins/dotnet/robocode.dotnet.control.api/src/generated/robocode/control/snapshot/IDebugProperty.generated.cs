/**
 * Copyright (c) 2001-2019 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * https://robocode.sourceforge.io/license/epl-v10.html
 */
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.8669
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace robocode.control.snapshot {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface IDebugProperty {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getValue();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getKey();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class IDebugProperty_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::robocode.control.snapshot.@__IDebugProperty.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::robocode.control.snapshot.IDebugProperty), typeof(global::robocode.control.snapshot.IDebugProperty_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::robocode.control.snapshot.IDebugProperty), typeof(global::robocode.control.snapshot.IDebugProperty_))]
    internal sealed partial class @__IDebugProperty : global::java.lang.Object, global::robocode.control.snapshot.IDebugProperty {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getValue0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getKey1;
        
        private @__IDebugProperty(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::robocode.control.snapshot.@__IDebugProperty.staticClass = @__class;
            global::robocode.control.snapshot.@__IDebugProperty.j4n_getValue0 = @__env.GetMethodID(global::robocode.control.snapshot.@__IDebugProperty.staticClass, "getValue", "()Ljava/lang/String;");
            global::robocode.control.snapshot.@__IDebugProperty.j4n_getKey1 = @__env.GetMethodID(global::robocode.control.snapshot.@__IDebugProperty.staticClass, "getKey", "()Ljava/lang/String;");
        }
        
        public global::java.lang.String getValue() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.snapshot.@__IDebugProperty.j4n_getValue0));
            }
        }
        
        public global::java.lang.String getKey() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.snapshot.@__IDebugProperty.j4n_getKey1));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IDebugProperty);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getValue", "getValue0", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getKey", "getKey1", "()Ljava/lang/String;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getValue0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::robocode.control.snapshot.IDebugProperty @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IDebugProperty>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getValue());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getKey1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::robocode.control.snapshot.IDebugProperty @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.IDebugProperty>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getKey());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::robocode.control.snapshot.@__IDebugProperty(@__env);
            }
        }
    }
    #endregion
}
