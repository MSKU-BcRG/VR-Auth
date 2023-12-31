<<<<<<< HEAD
using System;
using System.Collections.Generic;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEditor.TestTools.TestRunner.Api.Analytics;
using UnityEngine.TestRunner.NUnitExtensions;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    internal class CachingTestListProvider
    {
        private readonly ITestListProvider m_InnerTestListProvider;
        private readonly ITestListCache m_TestListCache;
        private readonly ITestAdaptorFactory m_TestAdaptorFactory;
        public CachingTestListProvider(ITestListProvider innerTestListProvider, ITestListCache testListCache, ITestAdaptorFactory testAdaptorFactory)
        {
            m_InnerTestListProvider = innerTestListProvider;
            m_TestListCache = testListCache;
            m_TestAdaptorFactory = testAdaptorFactory;
        }

        public IEnumerator<ITestAdaptor> GetTestListAsync(TestPlatform platform)
        {
            var testFromCache = m_TestListCache.GetTestFromCacheAsync(platform);
            while (testFromCache.MoveNext())
            {
                yield return null;
            }


            if (testFromCache.Current != null)
            {
                yield return testFromCache.Current;
            }
            else
            {
                var test = m_InnerTestListProvider.GetTestListAsync(platform);
                while (test.MoveNext())
                {
                    yield return null;
                }
                
                m_TestListCache.CacheTest(platform, test.Current);
                AnalyticsReporter.AnalyzeTestTreeAndReport(test.Current);
                yield return m_TestAdaptorFactory.Create(test.Current);
            }
        }
    }
}
=======
using System;
using System.Collections.Generic;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEditor.TestTools.TestRunner.Api.Analytics;
using UnityEngine.TestRunner.NUnitExtensions;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    internal class CachingTestListProvider
    {
        private readonly ITestListProvider m_InnerTestListProvider;
        private readonly ITestListCache m_TestListCache;
        private readonly ITestAdaptorFactory m_TestAdaptorFactory;
        public CachingTestListProvider(ITestListProvider innerTestListProvider, ITestListCache testListCache, ITestAdaptorFactory testAdaptorFactory)
        {
            m_InnerTestListProvider = innerTestListProvider;
            m_TestListCache = testListCache;
            m_TestAdaptorFactory = testAdaptorFactory;
        }

        public IEnumerator<ITestAdaptor> GetTestListAsync(TestPlatform platform)
        {
            var testFromCache = m_TestListCache.GetTestFromCacheAsync(platform);
            while (testFromCache.MoveNext())
            {
                yield return null;
            }


            if (testFromCache.Current != null)
            {
                yield return testFromCache.Current;
            }
            else
            {
                var test = m_InnerTestListProvider.GetTestListAsync(platform);
                while (test.MoveNext())
                {
                    yield return null;
                }
                
                m_TestListCache.CacheTest(platform, test.Current);
                AnalyticsReporter.AnalyzeTestTreeAndReport(test.Current);
                yield return m_TestAdaptorFactory.Create(test.Current);
            }
        }
    }
}
>>>>>>> 5386830ea95ecb9f6ce72cd172faa6cc6f38de24
