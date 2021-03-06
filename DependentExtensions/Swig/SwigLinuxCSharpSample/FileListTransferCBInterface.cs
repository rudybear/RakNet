/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class FileListTransferCBInterface : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FileListTransferCBInterface(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(FileListTransferCBInterface obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~FileListTransferCBInterface() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_FileListTransferCBInterface(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public FileListTransferCBInterface() : this(RakNetPINVOKE.new_FileListTransferCBInterface(), true) {
    SwigDirectorConnect();
  }

  public virtual bool OnFile(OnFileStruct onFileStruct) {
    bool ret = RakNetPINVOKE.FileListTransferCBInterface_OnFile(swigCPtr, OnFileStruct.getCPtr(onFileStruct));
    return ret;
  }

  public virtual void OnFileProgress(FileProgressStruct fps) {
    RakNetPINVOKE.FileListTransferCBInterface_OnFileProgress(swigCPtr, FileProgressStruct.getCPtr(fps));
  }

  public virtual bool Update() {
    bool ret = ((this.GetType() == typeof(FileListTransferCBInterface)) ? RakNetPINVOKE.FileListTransferCBInterface_Update(swigCPtr) : RakNetPINVOKE.FileListTransferCBInterface_UpdateSwigExplicitFileListTransferCBInterface(swigCPtr));
    return ret;
  }

  public virtual bool OnDownloadComplete() {
    bool ret = ((this.GetType() == typeof(FileListTransferCBInterface)) ? RakNetPINVOKE.FileListTransferCBInterface_OnDownloadComplete(swigCPtr) : RakNetPINVOKE.FileListTransferCBInterface_OnDownloadCompleteSwigExplicitFileListTransferCBInterface(swigCPtr));
    return ret;
  }

  public virtual void OnDereference() {
    if (this.GetType() == typeof(FileListTransferCBInterface)) RakNetPINVOKE.FileListTransferCBInterface_OnDereference(swigCPtr); else RakNetPINVOKE.FileListTransferCBInterface_OnDereferenceSwigExplicitFileListTransferCBInterface(swigCPtr);
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnFile", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateFileListTransferCBInterface_0(SwigDirectorOnFile);
    if (SwigDerivedClassHasMethod("OnFileProgress", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateFileListTransferCBInterface_1(SwigDirectorOnFileProgress);
    if (SwigDerivedClassHasMethod("Update", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateFileListTransferCBInterface_2(SwigDirectorUpdate);
    if (SwigDerivedClassHasMethod("OnDownloadComplete", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateFileListTransferCBInterface_3(SwigDirectorOnDownloadComplete);
    if (SwigDerivedClassHasMethod("OnDereference", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateFileListTransferCBInterface_4(SwigDirectorOnDereference);
    RakNetPINVOKE.FileListTransferCBInterface_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(FileListTransferCBInterface));
    return hasDerivedMethod;
  }

  private bool SwigDirectorOnFile(IntPtr onFileStruct) {
    return OnFile((onFileStruct == IntPtr.Zero) ? null : new OnFileStruct(onFileStruct, false));
  }

  private void SwigDirectorOnFileProgress(IntPtr fps) {
    OnFileProgress((fps == IntPtr.Zero) ? null : new FileProgressStruct(fps, false));
  }

  private bool SwigDirectorUpdate() {
    return Update();
  }

  private bool SwigDirectorOnDownloadComplete() {
    return OnDownloadComplete();
  }

  private void SwigDirectorOnDereference() {
    OnDereference();
  }

  public delegate bool SwigDelegateFileListTransferCBInterface_0(IntPtr onFileStruct);
  public delegate void SwigDelegateFileListTransferCBInterface_1(IntPtr fps);
  public delegate bool SwigDelegateFileListTransferCBInterface_2();
  public delegate bool SwigDelegateFileListTransferCBInterface_3();
  public delegate void SwigDelegateFileListTransferCBInterface_4();

  private SwigDelegateFileListTransferCBInterface_0 swigDelegate0;
  private SwigDelegateFileListTransferCBInterface_1 swigDelegate1;
  private SwigDelegateFileListTransferCBInterface_2 swigDelegate2;
  private SwigDelegateFileListTransferCBInterface_3 swigDelegate3;
  private SwigDelegateFileListTransferCBInterface_4 swigDelegate4;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(OnFileStruct) };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(FileProgressStruct) };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] {  };
  private static Type[] swigMethodTypes4 = new Type[] {  };
}

}
