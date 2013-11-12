/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Indri {

using System;
using System.Runtime.InteropServices;

public class QueryEnvironment : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal QueryEnvironment(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(QueryEnvironment obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~QueryEnvironment() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          indri_csharpPINVOKE.delete_QueryEnvironment(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public QueryEnvironment() : this(indri_csharpPINVOKE.new_QueryEnvironment(), true) {
  }

  public void addServer(string hostname) {
    indri_csharpPINVOKE.QueryEnvironment_addServer(swigCPtr, hostname);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void addIndex(string pathname) {
    indri_csharpPINVOKE.QueryEnvironment_addIndex(swigCPtr, pathname);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeServer(string hostname) {
    indri_csharpPINVOKE.QueryEnvironment_removeServer(swigCPtr, hostname);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeIndex(string pathname) {
    indri_csharpPINVOKE.QueryEnvironment_removeIndex(swigCPtr, pathname);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void close() {
    indri_csharpPINVOKE.QueryEnvironment_close(swigCPtr);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMemory(long memory) {
    indri_csharpPINVOKE.QueryEnvironment_setMemory(swigCPtr, memory);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setScoringRules(StringVector rules) {
    indri_csharpPINVOKE.QueryEnvironment_setScoringRules(swigCPtr, StringVector.getCPtr(rules));
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setStopwords(StringVector stopwords) {
    indri_csharpPINVOKE.QueryEnvironment_setStopwords(swigCPtr, StringVector.getCPtr(stopwords));
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public ScoredExtentResultVector runQuery(string query, int resultsRequested) {
    ScoredExtentResultVector ret = new ScoredExtentResultVector(indri_csharpPINVOKE.QueryEnvironment_runQuery__SWIG_0(swigCPtr, query, resultsRequested), true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ScoredExtentResultVector runQuery(string query, IntVector documentSet, int resultsRequested) {
    ScoredExtentResultVector ret = new ScoredExtentResultVector(indri_csharpPINVOKE.QueryEnvironment_runQuery__SWIG_1(swigCPtr, query, IntVector.getCPtr(documentSet), resultsRequested), true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QueryAnnotation runAnnotatedQuery(string query, int resultsRequested) {
    IntPtr cPtr = indri_csharpPINVOKE.QueryEnvironment_runAnnotatedQuery__SWIG_0(swigCPtr, query, resultsRequested);
    QueryAnnotation ret = (cPtr == IntPtr.Zero) ? null : new QueryAnnotation(cPtr, true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QueryAnnotation runAnnotatedQuery(string query, IntVector documentSet, int resultsRequested) {
    IntPtr cPtr = indri_csharpPINVOKE.QueryEnvironment_runAnnotatedQuery__SWIG_1(swigCPtr, query, IntVector.getCPtr(documentSet), resultsRequested);
    QueryAnnotation ret = (cPtr == IntPtr.Zero) ? null : new QueryAnnotation(cPtr, true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ParsedDocumentVector documents(IntVector documentIDs) {
    ParsedDocumentVector ret = new ParsedDocumentVector(indri_csharpPINVOKE.QueryEnvironment_documents__SWIG_0(swigCPtr, IntVector.getCPtr(documentIDs)), true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ParsedDocumentVector documents(ScoredExtentResultVector results) {
    ParsedDocumentVector ret = new ParsedDocumentVector(indri_csharpPINVOKE.QueryEnvironment_documents__SWIG_1(swigCPtr, ScoredExtentResultVector.getCPtr(results)), true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StringVector documentMetadata(IntVector documentIDs, string attributeName) {
    StringVector ret = new StringVector(indri_csharpPINVOKE.QueryEnvironment_documentMetadata__SWIG_0(swigCPtr, IntVector.getCPtr(documentIDs), attributeName), true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StringVector documentMetadata(ScoredExtentResultVector documentIDs, string attributeName) {
    StringVector ret = new StringVector(indri_csharpPINVOKE.QueryEnvironment_documentMetadata__SWIG_1(swigCPtr, ScoredExtentResultVector.getCPtr(documentIDs), attributeName), true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IntVector documentIDsFromMetadata(string attributeName, StringVector attributeValue) {
    IntVector ret = new IntVector(indri_csharpPINVOKE.QueryEnvironment_documentIDsFromMetadata(swigCPtr, attributeName, StringVector.getCPtr(attributeValue)), true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ParsedDocumentVector documentsFromMetadata(string attributeName, StringVector attributeValue) {
    ParsedDocumentVector ret = new ParsedDocumentVector(indri_csharpPINVOKE.QueryEnvironment_documentsFromMetadata(swigCPtr, attributeName, StringVector.getCPtr(attributeValue)), true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public long termCount() {
    long ret = indri_csharpPINVOKE.QueryEnvironment_termCount__SWIG_0(swigCPtr);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public long termCount(string term) {
    long ret = indri_csharpPINVOKE.QueryEnvironment_termCount__SWIG_1(swigCPtr, term);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public long termFieldCount(string term, string field) {
    long ret = indri_csharpPINVOKE.QueryEnvironment_termFieldCount(swigCPtr, term, field);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StringVector fieldList() {
    StringVector ret = new StringVector(indri_csharpPINVOKE.QueryEnvironment_fieldList(swigCPtr), true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public long documentCount() {
    long ret = indri_csharpPINVOKE.QueryEnvironment_documentCount__SWIG_0(swigCPtr);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public long documentCount(string term) {
    long ret = indri_csharpPINVOKE.QueryEnvironment_documentCount__SWIG_1(swigCPtr, term);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DocumentVectorVector documentVectors(IntVector documentIDs) {
    DocumentVectorVector ret = new DocumentVectorVector(indri_csharpPINVOKE.QueryEnvironment_documentVectors(swigCPtr, IntVector.getCPtr(documentIDs)), true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double expressionCount(string expression, string queryType) {
    double ret = indri_csharpPINVOKE.QueryEnvironment_expressionCount__SWIG_0(swigCPtr, expression, queryType);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double expressionCount(string expression) {
    double ret = indri_csharpPINVOKE.QueryEnvironment_expressionCount__SWIG_1(swigCPtr, expression);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double documentExpressionCount(string expression, string queryType) {
    double ret = indri_csharpPINVOKE.QueryEnvironment_documentExpressionCount__SWIG_0(swigCPtr, expression, queryType);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double documentExpressionCount(string expression) {
    double ret = indri_csharpPINVOKE.QueryEnvironment_documentExpressionCount__SWIG_1(swigCPtr, expression);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ScoredExtentResultVector expressionList(string expression, string queryType) {
    ScoredExtentResultVector ret = new ScoredExtentResultVector(indri_csharpPINVOKE.QueryEnvironment_expressionList__SWIG_0(swigCPtr, expression, queryType), true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ScoredExtentResultVector expressionList(string expression) {
    ScoredExtentResultVector ret = new ScoredExtentResultVector(indri_csharpPINVOKE.QueryEnvironment_expressionList__SWIG_1(swigCPtr, expression), true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int documentLength(int documentID) {
    int ret = indri_csharpPINVOKE.QueryEnvironment_documentLength(swigCPtr, documentID);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setFormulationParameters(Parameters p) {
    indri_csharpPINVOKE.QueryEnvironment_setFormulationParameters(swigCPtr, Parameters.getCPtr(p));
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public string reformulateQuery(string query) {
    string ret = indri_csharpPINVOKE.QueryEnvironment_reformulateQuery(swigCPtr, query);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
