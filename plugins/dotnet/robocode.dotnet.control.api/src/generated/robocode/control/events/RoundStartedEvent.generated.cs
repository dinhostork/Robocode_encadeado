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

namespace robocode.control.events {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class RoundStartedEvent : global::robocode.control.events.BattleEvent {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getRound0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getStartSnapshot1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorRoundStartedEvent2;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/snapshot/ITurnSnapshot;I)V")]
        public RoundStartedEvent(global::robocode.control.snapshot.ITurnSnapshot par0, int par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.NewObject(global::robocode.control.events.RoundStartedEvent.staticClass, global::robocode.control.events.RoundStartedEvent.j4n__ctorRoundStartedEvent2, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::robocode.control.snapshot.ITurnSnapshot>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
            }
        }
        
        protected RoundStartedEvent(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::robocode.control.events.RoundStartedEvent.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::robocode.control.events.RoundStartedEvent.staticClass = @__class;
            global::robocode.control.events.RoundStartedEvent.j4n_getRound0 = @__env.GetMethodID(global::robocode.control.events.RoundStartedEvent.staticClass, "getRound", "()I");
            global::robocode.control.events.RoundStartedEvent.j4n_getStartSnapshot1 = @__env.GetMethodID(global::robocode.control.events.RoundStartedEvent.staticClass, "getStartSnapshot", "()Lrobocode/control/snapshot/ITurnSnapshot;");
            global::robocode.control.events.RoundStartedEvent.j4n__ctorRoundStartedEvent2 = @__env.GetMethodID(global::robocode.control.events.RoundStartedEvent.staticClass, "<init>", "(Lrobocode/control/snapshot/ITurnSnapshot;I)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getRound() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::robocode.control.events.RoundStartedEvent.j4n_getRound0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lrobocode/control/snapshot/ITurnSnapshot;")]
        public virtual global::robocode.control.snapshot.ITurnSnapshot getStartSnapshot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.ITurnSnapshot>(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.events.RoundStartedEvent.j4n_getStartSnapshot1));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::robocode.control.events.RoundStartedEvent(@__env);
            }
        }
    }
    #endregion
}
