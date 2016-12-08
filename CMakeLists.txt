cmake_minimum_required(VERSION 3.6)
project(indri_git)

set(CMAKE_CXX_STANDARD 11)

find_package(Zlib)

add_subdirectory(contrib/antlr)
add_subdirectory(contrib/lemur)
add_subdirectory(contrib/xpdf)

set(SOURCE_FILES
#    buildindex/IndriBuildIndex.cpp
#    clarity/clarity.cpp
#    dumpindex/dumpindex.cpp
#    harvestlinks/harvestlinks.cpp
#    contrib/zlib/include/crc32.h
#    contrib/zlib/include/deflate.h
#    contrib/zlib/include/inffast.h
#    contrib/zlib/include/inffixed.h
#    contrib/zlib/include/inflate.h
#    contrib/zlib/include/inftrees.h
#    contrib/zlib/include/trees.h
#    contrib/zlib/include/zconf.h
#    contrib/zlib/include/zlib.h
#    contrib/zlib/include/zutil.h
#    contrib/zlib/src/adler32.c
#    contrib/zlib/src/compress.c
#    contrib/zlib/src/crc32.c
#    contrib/zlib/src/deflate.c
#    contrib/zlib/src/gzio.c
#    contrib/zlib/src/infback.c
#    contrib/zlib/src/inffast.c
#    contrib/zlib/src/inflate.c
#    contrib/zlib/src/inftrees.c
#    contrib/zlib/src/trees.c
#    contrib/zlib/src/uncompr.c
#    contrib/zlib/src/zutil.c
    include/indri/AnchorTextAnnotator.hpp
    include/indri/AnchorTextHarvester.hpp
    include/indri/AnchorTextWriter.hpp
    include/indri/Annotator.hpp
    include/indri/Appliers.hpp
    include/indri/Arabic_Stemmer_utf8.hpp
    include/indri/ArabicStemmerTransformation.hpp
    include/indri/atomic.hpp
    include/indri/AttributeValuePair.hpp
    include/indri/BeliefNode.hpp
    include/indri/BooleanAndNode.hpp
    include/indri/Buffer.hpp
    include/indri/BulkTree.hpp
    include/indri/CachedFrequencyBeliefNode.hpp
    include/indri/Collection.hpp
    include/indri/CombinedVocabularyIterator.hpp
    include/indri/Combiner.hpp
    include/indri/CompressedCollection.hpp
    include/indri/ConditionVariable.hpp
    include/indri/Conflater.hpp
    include/indri/ConflationPattern.hpp
    include/indri/ContextCountAccumulator.hpp
    include/indri/ContextCountGraphCopier.hpp
    include/indri/ContextCountGraphExtractor.hpp
    include/indri/ContextInclusionAndNode.hpp
    include/indri/ContextSimpleCountAccumulator.hpp
    include/indri/ContextSimpleCountCollectorCopier.hpp
    include/indri/Copier.hpp
    include/indri/CorpusStatistics.hpp
    include/indri/DagCopier.hpp
    include/indri/DateFieldAnnotator.hpp
    include/indri/DateParse.hpp
    include/indri/delete_range.hpp
    include/indri/DeletedDocumentList.hpp
    include/indri/DirectoryIterator.hpp
    include/indri/DirichletTermScoreFunction.hpp
    include/indri/DiskDocExtentListIterator.hpp
    include/indri/DiskDocListFileIterator.hpp
    include/indri/DiskDocListIterator.hpp
    include/indri/DiskDocumentDataIterator.hpp
    include/indri/DiskFrequentVocabularyIterator.hpp
    include/indri/DiskIndex.hpp
    include/indri/DiskKeyfileVocabularyIterator.hpp
    include/indri/DiskTermData.hpp
    include/indri/DiskTermListFileIterator.hpp
    include/indri/DocExtentListIterator.hpp
    include/indri/DocExtentListMemoryBuilder.hpp
    include/indri/DocListFileIterator.hpp
    include/indri/DocListIterator.hpp
    include/indri/DocListIteratorNode.hpp
    include/indri/DocListMemoryBuilder.hpp
    include/indri/DocumentCount.hpp
    include/indri/DocumentData.hpp
    include/indri/DocumentDataIterator.hpp
    include/indri/DocumentIterator.hpp
    include/indri/DocumentIteratorFactory.hpp
    include/indri/DocumentStructure.hpp
    include/indri/DocumentStructureHolderNode.hpp
    include/indri/DocumentVector.hpp
    include/indri/EvaluatorNode.hpp
    include/indri/Extent.hpp
    include/indri/ExtentAndNode.hpp
    include/indri/ExtentChildNode.hpp
    include/indri/ExtentDescendantNode.hpp
    include/indri/ExtentEnforcementNode.hpp
    include/indri/ExtentInsideNode.hpp
    include/indri/ExtentOrNode.hpp
    include/indri/ExtentParentNode.hpp
    include/indri/ExtentRestrictionModelAnnotatorCopier.hpp
    include/indri/ExtentRestrictionNode.hpp
    include/indri/FieldBelowWalker.hpp
    include/indri/FieldBetweenNode.hpp
    include/indri/FieldEqualsNode.hpp
    include/indri/FieldExtent.hpp
    include/indri/FieldGreaterNode.hpp
    include/indri/FieldIteratorNode.hpp
    include/indri/FieldLessNode.hpp
    include/indri/FieldListIterator.hpp
    include/indri/FieldStatistics.hpp
    include/indri/FieldWildcardNode.hpp
    include/indri/File.hpp
    include/indri/FileClassEnvironment.hpp
    include/indri/FileClassEnvironmentFactory.hpp
    include/indri/FileTreeIterator.hpp
    include/indri/FilterNode.hpp
    include/indri/FilterRejectNode.hpp
    include/indri/FilterRequireNode.hpp
    include/indri/FixedPassageNode.hpp
    include/indri/FrequencyListCopier.hpp
    include/indri/HashTable.hpp
    include/indri/HTMLParser.hpp
    include/indri/Index.hpp
    include/indri/IndexEnvironment.hpp
    include/indri/IndexWriter.hpp
    include/indri/indri-platform.h
    include/indri/IndriParser.hpp
    include/indri/IndriTimer.hpp
    include/indri/IndriTokenizer.hpp
    include/indri/InferenceNetwork.hpp
    include/indri/InferenceNetworkBuilder.hpp
    include/indri/InferenceNetworkNode.hpp
    include/indri/InternalFileBuffer.hpp
    include/indri/JelinekMercerTermScoreFunction.hpp
    include/indri/KrovetzStemmer.hpp
    include/indri/KrovetzStemmerTransformation.hpp
    include/indri/LengthPriorNode.hpp
    include/indri/ListAccumulator.hpp
    include/indri/ListBeliefNode.hpp
    include/indri/ListCache.hpp
    include/indri/ListIteratorNode.hpp
    include/indri/LocalQueryServer.hpp
    include/indri/Lockable.hpp
    include/indri/MaxNode.hpp
    include/indri/MboxDocumentIterator.hpp
    include/indri/MemoryDocumentDataIterator.hpp
    include/indri/MemoryIndex.hpp
    include/indri/MemoryIndexDocListFileIterator.hpp
    include/indri/MemoryIndexTermListFileIterator.hpp
    include/indri/MemoryIndexVocabularyIterator.hpp
    include/indri/MetadataPair.hpp
    include/indri/Mutex.hpp
    include/indri/NestedExtentInsideNode.hpp
    include/indri/NestedListBeliefNode.hpp
    include/indri/NetworkListener.hpp
    include/indri/NetworkMessageStream.hpp
    include/indri/NetworkServerProxy.hpp
    include/indri/NetworkServerStub.hpp
    include/indri/NetworkStream.hpp
    include/indri/NexiLexer.hpp
    include/indri/NexiLexerTokenTypes.hpp
    include/indri/NexiParser.hpp
    include/indri/NormalDistribution.hpp
    include/indri/NormalizationTransformation.hpp
    include/indri/NotNode.hpp
    include/indri/NullListNode.hpp
    include/indri/NullScorerNode.hpp
    include/indri/NumericFieldAnnotator.hpp
    include/indri/ObjectHandler.hpp
    include/indri/OfficeHelper.hpp
    include/indri/OffsetAnnotationAnnotator.hpp
    include/indri/OffsetMetadataAnnotator.hpp
    include/indri/OrderedWindowNode.hpp
    include/indri/OrNode.hpp
    include/indri/Packer.hpp
    include/indri/PageRank.hpp
    include/indri/Parameters.hpp
    include/indri/ParsedDocument.hpp
    include/indri/ParserFactory.hpp
    include/indri/Path.hpp
    include/indri/PDFDocumentExtractor.hpp
    include/indri/PlusNode.hpp
    include/indri/PonteExpander.hpp
    include/indri/Porter_Stemmer.hpp
    include/indri/PorterStemmerTransformation.hpp
    include/indri/PowerPointDocumentExtractor.hpp
    include/indri/PriorFactory.hpp
    include/indri/PriorListIterator.hpp
    include/indri/PriorNode.hpp
    include/indri/QueryAnnotation.hpp
    include/indri/QueryEnvironment.hpp
    include/indri/QueryExpander.hpp
    include/indri/QueryLexer.hpp
    include/indri/QueryLexerTokenTypes.hpp
    include/indri/QueryParser.hpp
    include/indri/QueryParserFactory.hpp
    include/indri/QueryResponsePacker.hpp
    include/indri/QueryResponseUnpacker.hpp
    include/indri/QueryServer.hpp
    include/indri/QuerySpec.hpp
    include/indri/QueryStopper.hpp
    include/indri/QueryTFWalker.hpp
    include/indri/RawScorerNodeExtractor.hpp
    include/indri/RawTextParser.hpp
    include/indri/ReaderLockable.hpp
    include/indri/ReadersWritersLock.hpp
    include/indri/ref_ptr.hpp
    include/indri/ReformulateQuery.hpp
    include/indri/RegionAllocator.hpp
    include/indri/RelevanceModel.hpp
    include/indri/Repository.hpp
    include/indri/RepositoryLoadThread.hpp
    include/indri/RepositoryMaintenanceThread.hpp
    include/indri/RMExpander.hpp
    include/indri/RVLCompressStream.hpp
    include/indri/RVLDecompressStream.hpp
    include/indri/ScopedLock.hpp
    include/indri/ScopedMonitor.hpp
    include/indri/ScoredExtentAccumulator.hpp
    include/indri/ScoredExtentResult.hpp
    include/indri/SequentialReadBuffer.hpp
    include/indri/SequentialWriteBuffer.hpp
    include/indri/ShrinkageBeliefNode.hpp
    include/indri/SimpleCopier.hpp
    include/indri/SkippingCapableNode.hpp
    include/indri/SmoothingAnnotatorWalker.hpp
    include/indri/SnippetBuilder.hpp
    include/indri/StemmerFactory.hpp
    include/indri/StopperTransformation.hpp
    include/indri/StopStructureRemover.hpp
    include/indri/SumNode.hpp
    include/indri/Tag.hpp
    include/indri/TagDocumentIterator.hpp
    include/indri/TagEvent.hpp
    include/indri/TagExtent.hpp
    include/indri/TaggedDocumentIterator.hpp
    include/indri/TaggedTextParser.hpp
    include/indri/TagList.hpp
    include/indri/TermBitmap.hpp
    include/indri/TermData.hpp
    include/indri/TermExtent.hpp
    include/indri/TermFieldStatistics.hpp
    include/indri/TermFrequencyBeliefNode.hpp
    include/indri/TermList.hpp
    include/indri/TermListFileIterator.hpp
    include/indri/TermRecorder.hpp
    include/indri/TermScoreFunction.hpp
    include/indri/TermScoreFunctionFactory.hpp
    include/indri/TermTranslator.hpp
    include/indri/TextDocumentExtractor.hpp
    include/indri/TextParser.hpp
    include/indri/TextTokenizer.hpp
    include/indri/TFIDFExpander.hpp
    include/indri/TFIDFTermScoreFunction.hpp
    include/indri/Thread.hpp
    include/indri/TokenizedDocument.hpp
    include/indri/TokenizerFactory.hpp
    include/indri/Transformation.hpp
    include/indri/TreePrinterWalker.hpp
    include/indri/TwoStageTermScoreFunction.hpp
    include/indri/uint64comp.hpp
    include/indri/UnnecessaryNodeRemoverCopier.hpp
    include/indri/UnorderedWindowNode.hpp
    include/indri/Unpacker.hpp
    include/indri/UnparsedDocument.hpp
    include/indri/URLTextAnnotator.hpp
    include/indri/UTF8CaseNormalizationTransformation.hpp
    include/indri/UTF8Transcoder.hpp
    include/indri/UtilityThread.hpp
    include/indri/VocabularyIterator.hpp
    include/indri/Walker.hpp
    include/indri/WARCDocumentIterator.hpp
    include/indri/WeightedAndNode.hpp
    include/indri/WeightedExtentOrNode.hpp
    include/indri/WeightedSumNode.hpp
    include/indri/WeightFoldingCopier.hpp
    include/indri/WordDocumentExtractor.hpp
    include/indri/WPlusNode.hpp
    include/indri/WriterLockable.hpp
    include/indri/XMLNode.hpp
    include/indri/XMLReader.hpp
    include/indri/XMLWriter.hpp
    indrid/IndriDaemon.cpp
#    makeprior/makeprior.cpp
#    modifyfields/ModifyFields.cpp
#    pagerank/pagerank.cpp
#    reformulate/ReformulateQuery.cpp
#    rmodel/rmodel.cpp
#    runquery/IndriRunQuery.cpp
#    site-search/cgi/CGIConfiguration.cpp
#    site-search/cgi/CGIConfiguration.h
#    site-search/cgi/CGIOutput.cpp
#    site-search/cgi/CGIOutput.h
#    site-search/cgi/DBInterface.cpp
#    site-search/cgi/DBInterface.h
#    site-search/cgi/DictionaryHash.cpp
#    site-search/cgi/DictionaryHash.h
#    site-search/cgi/IndriSearchInterface.cpp
#    site-search/cgi/IndriSearchInterface.h
#    site-search/cgi/LemurCGI.cpp
#    site-search/cgi/LemurSearchCGIConstants.h
#    site-search/cgi/SingleResultItem.cpp
#    site-search/cgi/SingleResultItem.h
    src/AnchorTextHarvester.cpp
    src/Annotator.cpp
    src/Arabic_Stemmer_utf8.cpp
    src/ArabicStemmerTransformation.cpp
    src/BooleanAndNode.cpp
    src/BulkTree.cpp
    src/CachedFrequencyBeliefNode.cpp
    src/CombinedVocabularyIterator.cpp
    src/Combiner.cpp
    src/CompressedCollection.cpp
    src/ContextCountAccumulator.cpp
    src/ContextInclusionAndNode.cpp
    src/ContextSimpleCountAccumulator.cpp
    src/Copier.cpp
    src/DeletedDocumentList.cpp
    src/DirectoryIterator.cpp
    src/DiskDocExtentListIterator.cpp
    src/DiskDocListFileIterator.cpp
    src/DiskDocListIterator.cpp
    src/DiskDocumentDataIterator.cpp
    src/DiskFrequentVocabularyIterator.cpp
    src/DiskIndex.cpp
    src/DiskKeyfileVocabularyIterator.cpp
    src/DiskTermListFileIterator.cpp
    src/DocExtentListMemoryBuilder.cpp
    src/DocExtentListMemoryBuilderIterator.cpp
    src/DocListIteratorNode.cpp
    src/DocListMemoryBuilder.cpp
    src/DocListMemoryBuilderIterator.cpp
    src/DocumentIteratorFactory.cpp
    src/DocumentStructure.cpp
    src/DocumentStructureHolderNode.cpp
    src/DocumentVector.cpp
    src/ExtentAndNode.cpp
    src/ExtentChildNode.cpp
    src/ExtentDescendantNode.cpp
    src/ExtentEnforcementNode.cpp
    src/ExtentInsideNode.cpp
    src/ExtentOrNode.cpp
    src/ExtentParentNode.cpp
    src/ExtentRestrictionNode.cpp
    src/FieldBetweenNode.cpp
    src/FieldEqualsNode.cpp
    src/FieldGreaterNode.cpp
    src/FieldIteratorNode.cpp
    src/FieldLessNode.cpp
    src/FieldWildcardNode.cpp
    src/File.cpp
    src/FileClassEnvironmentFactory.cpp
    src/FileTreeIterator.cpp
    src/FilterRejectNode.cpp
    src/FilterRequireNode.cpp
    src/FixedPassageNode.cpp
    src/HTMLParser.cpp
    src/IndexEnvironment.cpp
    src/IndexWriter.cpp
    src/IndriTimer.cpp
    src/InferenceNetwork.cpp
    src/InferenceNetworkBuilder.cpp
    src/KrovetzStemmer.cpp
    src/KrovetzStemmerTransformation.cpp
    src/LengthPriorNode.cpp
    src/ListAccumulator.cpp
    src/ListBeliefNode.cpp
    src/LocalQueryServer.cpp
    src/MboxDocumentIterator.cpp
    src/MemoryDocumentDataIterator.cpp
    src/MemoryIndex.cpp
    src/MemoryIndexTermListFileIterator.cpp
    src/NestedExtentInsideNode.cpp
    src/NestedListBeliefNode.cpp
    src/NetworkMessageStream.cpp
    src/NetworkServerProxy.cpp
    src/NetworkServerStub.cpp
    src/NexiLexer.cpp
    src/NexiParser.cpp
    src/NormalizationTransformation.cpp
    src/NotNode.cpp
    src/NullListNode.cpp
    src/NullScorerNode.cpp
    src/OfficeHelper.cpp
    src/OffsetAnnotationAnnotator.cpp
    src/OffsetMetadataAnnotator.cpp
    src/OrderedWindowNode.cpp
    src/OrNode.cpp
    src/Packer.cpp
    src/PageRank.cpp
    src/Parameters.cpp
    src/ParserFactory.cpp
    src/Path.cpp
    src/PDFDocumentExtractor.cpp
    src/PlusNode.cpp
    src/PonteExpander.cpp
    src/Porter_Stemmer.cpp
    src/PorterStemmerTransformation.cpp
    src/PowerPointDocumentExtractor.cpp
    src/PriorFactory.cpp
    src/PriorListIterator.cpp
    src/PriorNode.cpp
    src/QueryAnnotation.cpp
    src/QueryEnvironment.cpp
    src/QueryExpander.cpp
    src/QueryLexer.cpp
    src/QueryParser.cpp
    src/QueryParserFactory.cpp
    src/QueryStopper.cpp
    src/ReformulateQuery.cpp
    src/RelevanceModel.cpp
    src/Repository.cpp
    src/RepositoryLoadThread.cpp
    src/RepositoryMaintenanceThread.cpp
    src/RMExpander.cpp
    src/ShrinkageBeliefNode.cpp
    src/SnippetBuilder.cpp
    src/StemmerFactory.cpp
    src/StopperTransformation.cpp
    src/StopStructureRemover.cpp
    src/TaggedDocumentIterator.cpp
    src/TaggedTextParser.cpp
    src/TermFrequencyBeliefNode.cpp
    src/TermScoreFunctionFactory.cpp
    src/TextDocumentExtractor.cpp
    src/TextParser.cpp
    src/TextTokenizer.cpp
    src/TFIDFExpander.cpp
    src/TFIDFTermScoreFunction.cpp
    src/Thread.cpp
    src/TokenizerFactory.cpp
    src/uint64comp.cpp
    src/UnorderedWindowNode.cpp
    src/Unpacker.cpp
    src/UnpackerInternal.cpp
    src/UTF8CaseNormalizationTransformation.cpp
    src/UTF8Transcoder.cpp
    src/UtilityThread.cpp
    src/Walker.cpp
    src/WARCDocumentIterator.cpp
    src/WeightedAndNode.cpp
    src/WeightedExtentOrNode.cpp
    src/WeightedSumNode.cpp
    src/WordDocumentExtractor.cpp
    src/WPlusNode.cpp
    src/XMLNode.cpp
    src/XMLReader.cpp
    src/XMLWriter.cpp
)

add_library(indri STATIC ${SOURCE_FILES})
target_link_libraries(indri antlr xpdf lemur ${ZLIB_LIBRARIES})
target_include_directories(indri PUBLIC include contrib/lemur/indri contrib/xpdf/include)


add_subdirectory(buildindex)
add_subdirectory(dumpindex)