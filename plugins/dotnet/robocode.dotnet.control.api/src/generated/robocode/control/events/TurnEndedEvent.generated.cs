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
    public partial class TurnEndedEvent : global::robocode.control.events.BattleEvent {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getTurnSnapshot0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorTurnEndedEvent1;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/snapshot/ITurnSnapshot;)V")]
        public TurnEndedEvent(global::robocode.control.snapshot.ITurnSnapshot par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::robocode.control.events.TurnEndedEvent.staticClass, global::robocode.control.events.TurnEndedEvent.j4n__ctorTurnEndedEvent1, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::robocode.control.snapshot.ITurnSnapshot>(@__env, par0));
            }
        }
        
        protected TurnEndedEvent(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::robocode.control.events.TurnEndedEvent.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::robocode.control.events.TurnEndedEvent.staticClass = @__class;
            global::robocode.control.events.TurnEndedEvent.j4n_getTurnSnapshot0 = @__env.GetMethodID(global::robocode.control.events.TurnEndedEvent.staticClass, "getTurnSnapshot", "()Lrobocode/control/snapshot/ITurnSnapshot;");
            global::robocode.control.events.TurnEndedEvent.j4n__ctorTurnEndedEvent1 = @__env.GetMethodID(global::robocode.control.events.TurnEndedEvent.staticClass, "<init>", "(Lrobocode/control/snapshot/ITurnSnapshot;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lrobocode/control/snapshot/ITurnSnapshot;")]
        public virtual global::robocode.control.snapshot.ITurnSnapshot getTurnSnapshot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::robocode.control.snapshot.ITurnSnapshot>(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.events.TurnEndedEvent.j4n_getTurnSnapshot0));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::robocode.control.events.TurnEndedEvent(@__env);
            }
        }
    }
    #endregion
}