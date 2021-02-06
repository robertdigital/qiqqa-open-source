<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    
    <h1>Full Text Search Engines</h1>
<p>index.rst
<a href="https://xapian.org/docs/">https://xapian.org/docs/</a></p>
<p>.net - Indexing .PDF, .XLS, .DOC, .PPT using <a href="http://Lucene.NET">Lucene.NET</a> - Stack Overflow
<a href="https://stackoverflow.com/questions/4905271/indexing-pdf-xls-doc-ppt-using-lucene-net">https://stackoverflow.com/questions/4905271/indexing-pdf-xls-doc-ppt-using-lucene-net</a></p>
<p>Welcome to the <a href="http://Lucene.Net">Lucene.Net</a> website! | Apache <a href="http://Lucene.NET">Lucene.NET</a> 4.8.0
<a href="https://lucenenet.apache.org/">https://lucenenet.apache.org/</a></p>
<p>How to compile and use Xapian on Windows with C# - CodeProject
<a href="https://www.codeproject.com/Articles/71593/How-to-compile-and-use-Xapian-on-Windows-with-C">https://www.codeproject.com/Articles/71593/How-to-compile-and-use-Xapian-on-Windows-with-C</a></p>
<h1>Google Scholar</h1>
<p>You want BibTeX data, citations, etc. from Google.</p>
<p>[Edit: see <a href="#google-and-the-publishers">Google and the Publishers</a> section below for a very probable cause of the Scholar RECAPTCHA woes.]</p>
<p>Let’s not be squeamish about it: in exchange, Google wants your <em>soul</em>. Or your money, but in the case of Google Scholar, only your <em>soul</em> will do: lots of effort has been expended by Google in the last 1-2 years to <strong>block everyone that’s not provably a human using a modern browser <em>manually</em></strong>. And even than, you’re limited to only so much use of Scholar before you’re supposed to go back to basic Search, which at least can soak you in ads.</p>
<p>Sounds opinionated? Well, it’s “<em>follow the money</em>” as usual: if you <em>assume</em> Google is interested in <strong>human activity only</strong> – or more specifically stated: Google is <strong>only interested in humans who can click on ads</strong> – then <em>all</em> behavioural changes of the Google Scholar site over the recent months/years are <em>reasonable</em>:</p>
<ul>
<li>kill/thwart any robot activity on the site (heck, they could only be crawling, and <em>we, the Google</em> are the only ones who should be doing <em>that</em>!)</li>
<li>kill/thwart any old browsers: that’s humans with browsers/machines which will probably break on all those fancy modern commercial websites anyway, while using an outdated browser also clearly marks you as <em>having no purchase mandate or purchase budget</em>: you’re either a worker bee deep inside corporate firewalls or you’re not, ah, sufficiently pecuniary advanced to purchase something modern, with a recent operating system and ditto browser. That’s near zero buyer’s potential right there. Hence, we’re not interested. Bye.</li>
<li>kill/thwart any human that’s potentially wiping ads using filtering proxies (e.g. <a href="https://www.privoxy.org/">privoxy</a>) and such: you might be tech savvy, but we are <em>savvier</em>: if your HTTP request signature doesn’t look like it’s coming from a vanilla Chrome/Safari/FireFox/Edge browser, you’re probably not worth our while either. You get a few answers to show you we mean well, but nothing to generous.
<ul>
<li>when you ‘log in’ into your Google account while using Scholar, emperical data hints that you get more responses before you’re hit with a “not-a-robot?” query by your friends at Google.</li>
</ul>
</li>
<li>don’t give out many responses per unit of time: that sounds like crawling or heavy use: that should be monetized and while it isn’t, we’re going to send you through captcha hoops.</li>
</ul>
<p>The nett effect is that <strong>any embedded browser</strong> is dead in the water unless you make some serious effort to make it not appear so. The corrolary of this, by the way, is that a Google Scholar session inside an <code>\&lt;iframe&gt;</code> is a <strong>not-happening</strong> situation either: I have yet to find out exactly what metrics Google is inspecting to detect embedded browsers, but it certainly looks at the <code>User-Agent</code> and possibly at traffic, for it’s rather <em>uncanny</em> how good Google has become at detecting these things…</p>
<p>This translates to the Qiqqa Sniffer being a, ah, ‘<em>challenge</em>’ to make it work again in 2020 A.D.: one must make it look like it’s the genuine Chrome browser and no hanky panky happenin’, or you get toasted with CAPTCHA/robot checks and 503/429 HTTP error reponses, i.e. <em>no results what-so-ever</em> until you return the next day and try again.</p>
<p>Meanwhile, Google also seems to have added a VPN exit node blacklist of some sort as using a VPN to perform Google Scholar searches doesn’t seem to help: it was rather <em>worse</em> than Scholar-ing from the private node. Having had a look at <code>scholarly</code> (below) which uses the <code>tor</code> network as a randomizing VPN/proxy rig might fly better for a while, but I don’t know how long Google will keep up appearances regarding <code>tor</code> and disadvantaged web users from beyond the Great Firewall and elsewhere: in the end, they’re in it for the money. My opinion here: when / as-long-as the <code>tor</code> road works, heck, let’s do it!</p>
<h2>Google and the Publishers</h2>
<p>Found via the README of the project <a href="https://github.com/edsu/etudier"><code>edsu/etudier</code>: “Extract a citation network from Google Scholar”</a>:</p>
<blockquote>
<p>If you are wondering why it uses a non-headless browser it’s because <a href="https://www.quora.com/Are-there-technological-or-logistical-challenges-that-explain-why-Google-does-not-have-an-official-API-for-Google-Scholar">Google is quite protective of this data</a> and routinely will ask you to solve a captcha (identifying street signs, cars, etc in photos). étudier will allow you to complete these tasks when they occur and then will continue on its way collecting data.</p>
</blockquote>
<p><strong>Follow the money</strong>: following the link in the README above, Quora says:</p>
<blockquote>
<p>Aaron Tay, academic librarian who has studied, blogged and presented on Google scholar</p>
<p>Updated August 11, 2016</p>
<p>I’ve read or heard someone say that Google Scholar is given privileged access to crawl Publisher,aggregator (often enhanced with subject heading and controlled vocab) and none-free abstract and indexing sites like Elsevier and Thomson Reuters’s Scopus and Web of Science respectively.</p>
<p>Obviously the latter two wouldn’t be so wild about Google Scholar offering a API that would expose all their content to anyone since they sell access to such metadata.</p>
<p>Currently you only get such content (relatively rare) from GS if you are in the specific institution IP range that has subscriptions. (Also If your institution is already a subscriber to such services such as Web of Science or Scopus, you library could usually with some work allow you access directly via the specific resource API!.)</p>
<p>Even publishers like Wiley that are usually happy for their metadata to be freely available might not like the idea of a Google Scholar API. The reason is unlike Google, Google Scholar actually has access to the full text as well (which they sell)… If the API exposes that…</p>
<p>There are of course technical solutions if Google wants the API enough, but why would they make the effort?</p>
<p>As already mentioned Libraries do pay for things like Web of Science and Scopus and these services do provide APIs, so do consult a librarian if you have such access.</p>
<p>Also Web Scale discovery services that libraries pay for such as Summon, Ebsco discovery service, Primo etc do have APIs and they come closest to duplicating a (less comprehensive version) Google Scholar API</p>
<p>Another poor substitute to a Google Scholar API, is the Crossref Metadata Search. It’s not as comprehensive as Google Scholar but most major publishers do deposit their metadata.</p>
<hr>
<p>Tom Griffin, works at IEEE</p>
<p>Answered July 15, 2013</p>
<p>Google doesn’t have an API for Scholar likely for the same reason they don’t have an API for web search - it would get overwhelmed by applications creating aggregation platforms (and running continuous queries) versus applications that just run on-demand, user-initiated lookups (like Mendeley linking out to Google Scholar).</p>
<p>Couple this with the fact that Scholar is a philanthropic and they make no money off of it - there certainly isn’t the pressing need for an API.</p>
<p>There are, however, some openly available scrapers that work as an API. Of course, they only work well if they’re tuned to the current structure of Scholar search results. One such example</p>
<p><a href="https://www.icir.org/christian/scholar.html">A Parser for Google Scholar</a></p>
<p>The other thing to note is that Microsoft Academic Search does offer an API. You need to request a key, but other than that, it provides full programatic access to what the application returns using the web interface.</p>
<p><a href="https://www.microsoft.com/en-us/research/project/academic/articles/sign-academic-knowledge-api/">Microsoft Academic Search API</a></p>
</blockquote>
<h2>Analysis Notes</h2>
<ul>
<li>
<p>at least <em>some</em> of the Python repositories concerning themselves with Google Scholar crawling are using the python module <a href="https://pypi.org/project/scholarly/"><code>scholarly</code></a> under the hood.</p>
<p>Upon closer inspection of <a href="https://github.com/scholarly-python-package/scholarly">the source code</a>, that one appears to circumvent the Google Scholar restrictions by using a few tricks – see also <a href="https://github.com/scholarly-python-package/scholarly/blob/master/scholarly/_navigator.py#L82"><code>scholarly/_navigator.py</code></a>:</p>
<ul>
<li>
<p>using the <code>tor</code> <strong>proxy</strong> as a randomizing proxy, if available locally.</p>
<p>When a CAPTCHA from Google is detected, <a href="https://github.com/scholarly-python-package/scholarly/blob/master/scholarly/_navigator.py#L113">the tor proxy is refreshed</a> so our next (re)try would exit on a different tor network node.</p>
</li>
<li>
<p>sending <a href="https://github.com/scholarly-python-package/scholarly/blob/master/scholarly/_navigator.py#L90">a randomized <code>User-Agent</code></a> to thwart Google’s same-user detection heuristics. The UserAgent is randomly picked from a sane set using <a href="https://pypi.org/project/fake-useragent/">the Python module <code>fake_useragent</code></a>, which uses real-world User-Agent strings from [<a href="http://useragentstring.com">useragentstring.com</a>] – see also <a href="https://github.com/hellysmile/fake-useragent">its source code at github</a>.</p>
</li>
<li>
<p><a href="https://github.com/scholarly-python-package/scholarly/blob/master/scholarly/_navigator.py#L91">randomizing the GoogleID in the cookie that is sent along</a> with the search query.</p>
</li>
</ul>
</li>
</ul>
<hr>
<h2>jkeirstead/scholar: Analyse citation data from Google Scholar</h2>
<p><a href="https://github.com/jkeirstead/scholar">https://github.com/jkeirstead/scholar</a></p>
<p>The scholar R package provides functions to extract citation data from Google Scholar. In addition to retrieving basic information about a single scholar, the package also allows you to compare multiple scholars and predict future h-index values.</p>
<h3>Basic features</h3>
<p>Individual scholars are referenced by a unique character string, which can be found by searching for an author and inspecting the resulting scholar homepage. For example, the profile of physicist Richard Feynman is located at <a href="http://scholar.google.com/citations?user=B7vSqZsAAAAJ">http://scholar.google.com/citations?user=B7vSqZsAAAAJ</a> and so his unique id is B7vSqZsAAAAJ.</p>
<h3>Analysis Notes</h3>
<ul>
<li>
<p>Does some work to carry google cookies – see <a href="https://github.com/jkeirstead/scholar/blob/master/R/utils.R"><code>/R/utils.R</code></a> and <a href="https://github.com/jkeirstead/scholar/blob/master/R/scholar.r"><code>/R/scholar.r</code></a></p>
</li>
<li>
<p>Does not do any randomization or other Google Scholar thwarting.</p>
</li>
<li>
<p>However, it <em>does</em> detect Google HTTP response code 429:</p>
<pre class="language-R"><code class="language-R">else if (httr::status_code(resp) == 429) {
  stop(&quot;Response code 429. Google is rate limiting you for making too many requests too quickly.&quot;)
}
</code></pre>
</li>
</ul>
<h2>venthur/gscholar: Query Google Scholar with Python</h2>
<p><a href="https://github.com/venthur/gscholar">https://github.com/venthur/gscholar</a></p>
<h3>Using <code>gscholar</code> as a command line tool</h3>
<p><code>gscholar</code> provides a command line tool, to use it, just call <code>gscholar</code> like:</p>
<pre class="language-sh"><code class="language-sh">$ gscholar &quot;albert einstein&quot;
</code></pre>
<p>or</p>
<pre class="language-sh"><code class="language-sh">$ python3 -m gscholar &quot;albert einstein&quot;
</code></pre>
<p>Getting more results:</p>
<pre class="language-sh"><code class="language-sh">$ gscholar --all &quot;some author or title&quot;
</code></pre>
<p>Same as above but returns up to 10 bibtex items. (Use with caution Google will assume you’re a bot an ban you’re IP temporarily)</p>
<p>Querying using a pdf:</p>
<pre class="language-sh"><code class="language-sh">$ gscholar /path/to/pdf
</code></pre>
<p>Will read the pdf to generate a Google Scholar query. It uses this query to show the first bibtex result as above.</p>
<p>Renaming a pdf:</p>
<pre class="language-sh"><code class="language-sh">$ gscholar --rename /path/to/pdf
</code></pre>
<p>Will do the same as above but asks you if it should rename the file according to the bibtex result. You have to answer with “y”, default answer is no.</p>
<h3>Analysis Notes</h3>
<p>Nothing fancy. Does use <a href="https://github.com/venthur/gscholar/blob/master/gscholar/gscholar.py#L64">Google Scholar cookie</a> to request BibTeX (<a href="https://github.com/venthur/gscholar/blob/master/gscholar/gscholar.py#L34">or other format</a>).</p>
<h2>ckreibich/scholar.py: A parser for Google Scholar, written in Python</h2>
<p><a href="https://github.com/ckreibich/scholar.py">https://github.com/ckreibich/scholar.py</a></p>
<p><a href="http://scholar.py">scholar.py</a> is a Python module that implements a querier and parser for Google Scholar’s output. Its classes can be used independently, but it can also be invoked as a command-line tool.</p>
<p>The script used to live at <a href="http://icir.org/christian/scholar.html">http://icir.org/christian/scholar.html</a>, and I’ve moved it here so I can more easily manage the various patches and suggestions I’m receiving for <a href="http://scholar.py">scholar.py</a>.</p>
<h3>Analysis Notes</h3>
<p>No fancy stuff. Is aware of Scholar quirks but has no smart circumventions.</p>
<p>Does have <a href="https://github.com/ckreibich/scholar.py/blob/master/scholar.py">a nice list of query options</a> for Scholar though.</p>
<p>Has 61 open issues at the time of writing and 44 pull requests. For example, there’s the dreaded <a href="https://github.com/ckreibich/scholar.py/issues/106">HTTP Error 503: Service Unavailable</a> we’ve encountered so often ourselves.</p>
<p>Might be worth to merge several of those and mix in the <code>scholarly</code> library’s smart circumvention tactics to make this a viable tool in 2020 A.D.</p>
<h2>WittmannF/sort-google-scholar: Sorting Google Scholar search results based on the number of citations</h2>
<p><a href="https://github.com/WittmannF/sort-google-scholar">https://github.com/WittmannF/sort-google-scholar</a></p>
<p>This Python code ranks publications data from Google Scholar by the number of citations. It is useful for finding relevant papers in a specific field.</p>
<p>The data acquired from Google Scholar is Title, Citations, Links and Rank. A new columns with the number of citations per year is also included. The example of the code will look for the top 100 papers related to the keyword, and rank them by the number of citations. This keyword can eiter be included in the command line terminal ($python <a href="http://sortgs.py">sortgs.py</a> --kw ‘my keyword’) or edited in the original file. As output, a .csv file will be returned with the name of the chosen keyword ranked by the number of citations.</p>
<p><strong>GOOGLE COLAB</strong>: Try running the code using Google Colab! No install requirements! Limitations: Can’t handle robot checking, so use it carefully.</p>
<p>Handling robot checking with Selenium and Chrome browser: You might be asked to manually solve the first captcha for retrieving the content of the pages.</p>
<h3>Analysis Notes</h3>
<p>Nice, but like most of the others: no circumvention techniques. Uses Selenium to kickstart your Chrome browser so you can answer the Google CAPTCHAs, but that’s it.</p>
<h2>beloglazov/zotero-scholar-citations: Zotero plugin for auto-fetching numbers of citations from Google Scholar</h2>
<p><a href="https://github.com/beloglazov/zotero-scholar-citations">https://github.com/beloglazov/zotero-scholar-citations</a></p>
<p>This is an add-on for Zotero, a research source management tool. The add-on automatically fetches numbers of citations of your Zotero items from Google Scholar and makes it possible to sort your items by the citations. Moreover, it allows batch updating the citations, as they may change over time.</p>
<p>When updating multiple citations in a batch, it may happen that citation queries are blocked by Google Scholar for multiple automated requests. If a blockage happens, the add-on opens a browser window and directs it to <a href="http://scholar.google.com/">http://scholar.google.com/</a>, where you should see a Captcha displayed by Google Scholar, which you need to enter to get unblocked and then re-try updating the citations. It may happen that Google Scholar displays a message like the following “We’re sorry… but your computer or network may be sending automated queries. To protect our users, we can’t process your request right now.” In that case, the only solution is to wait for a while until Google unblocks you.</p>
<h3>Analysis Notes</h3>
<p>That stuff <a href="https://github.com/beloglazov/zotero-scholar-citations/blob/master/chrome/content/scripts/zoteroscholarcitations.js#L173">happens here</a>.</p>
<h2>lintool/scholar-scraper: Scrapes citation statistics from Google Scholar</h2>
<p><a href="https://github.com/lintool/scholar-scraper">https://github.com/lintool/scholar-scraper</a></p>
<p>I wrote this simple utility to scrape citation statistics of researcher profiles on Google Scholar, using it as an opportunity to learn node.js. I began with a list of information retrieval researchers, but have since expanded to include a separate list of researchers in human-computer interaction. The results are here.</p>
<p><strong>Editorial note</strong>: This list contains only researchers who have a Google Scholar profile; names were identified by snowball sampling and various other ad hoc techniques. If you wish to see a name added, please email me or send a pull request. I will endeavor to periodically run the crawl to gather updated statistics. Of course, scholarly achievement is only partially measured by citation counts, which are known to be flawed in many ways. Evaluations of scholars should include comprehensive examination of their research contributions.</p>
<h3>Analysis Notes</h3>
<p>Basic Scholar access, nothing fancy. Done <a href="https://github.com/lintool/scholar-scraper/blob/master/scrape.js#L12">here</a>.</p>
<h2>jimmytidey/bibnet-google-scholar-scraper</h2>
<p><a href="https://github.com/jimmytidey/bibnet-google-scholar-scraper">https://github.com/jimmytidey/bibnet-google-scholar-scraper</a></p>
<h3>Google and rate limiting</h3>
<p>This software should be used in compliance with Google’s rules. Much as Zotero uses Google Scholar’s results pages to populate it’s metadata fields, this seems like a reasonable use of their service.</p>
<p>There is a keys.js where you can provide cookie details, so that you are querying Google as a logged in user. I don’t think this adds any particular advantage.</p>
<h2>dnlcrl/PyScholar: A ‘supervised’ parser for Google Scholar</h2>
<p><a href="https://github.com/dnlcrl/PyScholar">https://github.com/dnlcrl/PyScholar</a></p>
<p>A “supervised” parser for Google Scholar, written in Python.</p>
<p>PyScholar is a command line tool written in python that implements a querier and parser for Google Scholar’s output. This project is inspired by <a href="http://scholar.py">scholar.py</a>, in fact there is a lot of code from that project, the main difference is that <a href="http://scholar.py">scholar.py</a> makes use of the urllib modules, thus, so no javascript, and given that people at big G don’t like you to scrape their search results, when the server responses the “I’m not a robot” page, you simply get no output from <a href="http://scholar.py">scholar.py</a>, for a long time. Instead PyScholar makes use of selenium webdriver giving the ability to see what’s going on and in case the “I’m not a robot” shows up you can simply pass the challenge manually and let the scraper continue his job.</p>
<p>Also there are some other new features I inclulded from my <a href="http://scholar.py">scholar.py</a> fork, that are: json exporting of the reults, “starting result” option, and the potential ability to get an unlimited number results, even if it seems that results are limited on server-side to approximately one thousand.</p>
<h3>Analysis Notes</h3>
<p>Hmmmm… Last work was done 5 years ago, but at least this sounds like something. It doesn’t have <code>scholarly</code>’s twists, but it does have the ‘pop up Chrome via Selenium so user can do the captcha thing’ approach at least.</p>
<p>Interesting. Should be tested…</p>
<h2>edsu/etudier: Extract a citation network from Google Scholar</h2>
<p><a href="https://github.com/edsu/etudier">https://github.com/edsu/etudier</a></p>
<p>étudier is a small Python program that uses Selenium and requests-html to drive a non-headless browser to collect a citation graph around a particular Google Scholar citation or set of search results. The resulting network is written out as a Gephi file and a D3 visualization using networkx. The D3 visualization could use some work, so if you add style to it please submit a pull request.</p>
<p>If you are wondering why it uses a non-headless browser it’s because <a href="https://www.quora.com/Are-there-technological-or-logistical-challenges-that-explain-why-Google-does-not-have-an-official-API-for-Google-Scholar">Google is quite protective of this data</a> and routinely will ask you to solve a captcha (identifying street signs, cars, etc in photos). étudier will allow you to complete these tasks when they occur and then will continue on its way collecting data.</p>
<h3>Analysis notes</h3>
<p><strong>Follow the money</strong>: following the link in the README above, Quora says:</p>
<blockquote>
<p>Aaron Tay, academic librarian who has studied, blogged and presented on Google scholar</p>
<p>Updated August 11, 2016</p>
<p>I’ve read or heard someone say that Google Scholar is given privileged access to crawl Publisher,aggregator (often enhanced with subject heading and controlled vocab) and none-free abstract and indexing sites like Elsevier and Thomson Reuters’s Scopus and Web of Science respectively.</p>
<p>Obviously the latter two wouldn’t be so wild about Google Scholar offering a API that would expose all their content to anyone since they sell access to such metadata.</p>
<p>Currently you only get such content (relatively rare) from GS if you are in the specific institution IP range that has subscriptions. (Also If your institution is already a subscriber to such services such as Web of Science or Scopus, you library could usually with some work allow you access directly via the specific resource API!.)</p>
<p>Even publishers like Wiley that are usually happy for their metadata to be freely available might not like the idea of a Google Scholar API. The reason is unlike Google, Google Scholar actually has access to the full text as well (which they sell)… If the API exposes that…</p>
<p>There are of course technical solutions if Google wants the API enough, but why would they make the effort?</p>
<p>As already mentioned Libraries do pay for things like Web of Science and Scopus and these services do provide APIs, so do consult a librarian if you have such access.</p>
<p>Also Web Scale discovery services that libraries pay for such as Summon, Ebsco discovery service, Primo etc do have APIs and they come closest to duplicating a (less comprehensive version) Google Scholar API</p>
<p>Another poor substitute to a Google Scholar API, is the Crossref Metadata Search. It’s not as comprehensive as Google Scholar but most major publishers do deposit their metadata.</p>
<hr>
<p>Tom Griffin, works at IEEE</p>
<p>Answered July 15, 2013</p>
<p>Google doesn’t have an API for Scholar likely for the same reason they don’t have an API for web search - it would get overwhelmed by applications creating aggregation platforms (and running continuous queries) versus applications that just run on-demand, user-initiated lookups (like Mendeley linking out to Google Scholar).</p>
<p>Couple this with the fact that Scholar is a philanthropic and they make no money off of it - there certainly isn’t the pressing need for an API.</p>
<p>There are, however, some openly available scrapers that work as an API. Of course, they only work well if they’re tuned to the current structure of Scholar search results. One such example</p>
<p><a href="https://www.icir.org/christian/scholar.html">A Parser for Google Scholar</a></p>
<p>The other thing to note is that Microsoft Academic Search does offer an API. You need to request a key, but other than that, it provides full programatic access to what the application returns using the web interface.</p>
<p><a href="https://www.microsoft.com/en-us/research/project/academic/articles/sign-academic-knowledge-api/">Microsoft Academic Search API</a></p>
</blockquote>
<h2>VT-CHCI/google-scholar: nodejs module for searching google scholar</h2>
<p><a href="https://github.com/VT-CHCI/google-scholar">https://github.com/VT-CHCI/google-scholar</a></p>
<p>nodejs module for searching google scholar</p>
<h3>Analysis Notes</h3>
<p>Has <a href="https://github.com/VT-CHCI/google-scholar/blob/master/index.js#L7">request rate limiting and some HTTP error response detection logic</a>, but no circumventions.</p>
<p>Done in JS, so might be handier to start with than some Python code if we want to roll it into Qiqqa.</p>
<h2>linhung0319/google-scholar-crawler: A crawler to crawl google scholar search page</h2>
<p><a href="https://github.com/linhung0319/google-scholar-crawler">https://github.com/linhung0319/google-scholar-crawler</a></p>
<p>這是我練習寫的一個爬取Google Scholar Search Page的網路爬蟲程式</p>
<p>zhè shì wǒ liànxí xiě de yīgè pá qǔ Google Scholar Search Page de wǎng lù páchóng chéngshì</p>
<p>This is a web crawler program that I practice to write to crawl Google Scholar Search Page</p>
<p>How to Use</p>
<ol>
<li>
<p>Go to Google Scholar Search and enter the keywords you want to find, arrive at the first page of the Search Page, and copy the URL of this page</p>
</li>
<li>
<p>Enter google_crawler.py and put the copied URL into start_url, start_url =‘URL’</p>
</li>
<li>
<p>p_key puts the keywords you want to find, n_key puts the keywords you don’t want to find in the Search Page, the title and content of each cell, if it contains the words in p_key, Crawler will tend to grab this paper.</p>
<p>In the page, if the title and content of each cell contain the words in n_key, Crawler will tend to ignore this paper.</p>
<p>In the above picture, because I want to find the paper related to sound, not to find the paper related to optics, so p_key Put sound-related words in the n_key and optical-related words in the n_key</p>
</li>
<li>
<p>Set page = number, you can set the Google Search Page to be crawled. Setting too many pages will induce Google’s robot check</p>
</li>
<li>
<p>Start execution The program runs google_crawler.py in Terminal.</p>
</li>
</ol>
<p><code>$ python google_crawler.py</code> will save the captured data (‘title’,‘year’,‘url’,…) in result.pickle and then run csvNdownload in <a href="http://terminal.py">terminal.py</a></p>
<p><code>$ python csvNdownload.py</code> Convert the data to a CSV file, save it in a CSV folder, download <abbr title="[object Object]">links</abbr> with Tag (PDF, HTML) to PDF files, and save them separately into PDF, HTML folder</p>
<h3>Google Robot Check</h3>
<p>Google Search Page will be anti-crawling Detection. If the speed of downloading or viewing web pages is too fast, he will suspect that you are a robot and ban your IP address.
The simplest method currently in mind is to use a VPN. When it is considered a robot, use it.</p>
<p>VPN immediately changes its IP address. Now there are many free VPNs on the Internet that can be downloaded.</p>
<p>If a message appears when running Crawler</p>
<p>__findPages - Can not find the pages link in the start URL!!</p>
<p>__findPages - 1. Google robot check might ban you from crawling!!</p>
<p>__findPages - 2. You might not crawl the page of google scholar</p>
<p>The solution is to use VPN and change IP</p>
<h2>cute-jumper/gscholar-bibtex: Retrieve BibTeX entries from Google Scholar, ACM Digital Library, IEEE Xplore and DBLP</h2>
<p><a href="https://github.com/cute-jumper/gscholar-bibtex">https://github.com/cute-jumper/gscholar-bibtex</a></p>
<h3>Analysis Notes</h3>
<p>Looks like a pretty vanilla scraper. Has extras for other sites though:</p>
<blockquote>
<p>Retrieve BibTeX entries from Google Scholar, ACM Digital Library, IEEE Xplore and DBLP by your query. All in Emacs Lisp!</p>
<p><em>UPDATE</em>: ACM Digital Library, IEEE Xplore, and DBLP are now supported though the package name doesn’t suggest that.</p>
<p><a href="https://github.com/cute-jumper/gscholar-bibtex/blob/master/gscholar-bibtex.el">https://github.com/cute-jumper/gscholar-bibtex/blob/master/gscholar-bibtex.el</a></p>
</blockquote>
<h2>alberto-martin/googlescholar: Code to extract bibliographic data from Google Scholar</h2>
<p><a href="https://github.com/alberto-martin/googlescholar">https://github.com/alberto-martin/googlescholar</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>
<p>Uses Selenium driver approach</p>
</li>
<li>
<p>Uses <code>scrapy</code> package</p>
</li>
<li>
<p>From the README:</p>
<p>Be aware that if too many queries are carried out in a short period of time, Google Scholar will ask you to solve one or several CAPTCHAs, or will directly block you. The script will detect when Google Scholar requests a CAPTCHA, and will pause if this happens. The user must solve the CAPTCHA manually. When the browser resumes displaying search results, the user can resume the process by clicking enter in the terminal window. This script cannot resume automatically after Google Scholar has blocked you for making too many queries.</p>
</li>
</ul>
<h2>leventsagun/scholar-bib-scraper: Get bibtex from saved Google Scholar articles</h2>
<p><a href="https://github.com/leventsagun/scholar-bib-scraper">https://github.com/leventsagun/scholar-bib-scraper</a></p>
<h3>Analysis Notes</h3>
<p>Another Selenium driver based tool.</p>
<p>From the README:</p>
<p>Little script to get BibTeX entries of Google Scholar articles that are saved in personal accounts (for some reason Google Scholar doesn’t have a bulk export option for all saved articles).</p>
<p>Requires manual login and possible reCAPTCHA solving at the beginning.</p>
<h2>supasorn/GoogleScholarCopyBibTeX: Copy BibTeX on Google Scholar Search page with a single click</h2>
<p><a href="https://github.com/supasorn/GoogleScholarCopyBibTeX">https://github.com/supasorn/GoogleScholarCopyBibTeX</a></p>
<p>A Chrome plugin that adds “Copy BibTeX” button to Google Scholar Search result. BibTex can be copied to your system’s clipboard with a single click. <a href="https://chrome.google.com/webstore/detail/google-scholar-bibtex/lpadjkikoegfojgbhapfmkanmpoejdia">https://chrome.google.com/webstore/detail/google-scholar-bibtex/lpadjkikoegfojgbhapfmkanmpoejdia</a></p>
<h2>maikelronnau/google_scholar_paper_finder: A engine that searches for papers on Google Scholar based on keywords extracted from a text.</h2>
<p><a href="https://github.com/maikelronnau/google_scholar_paper_finder">https://github.com/maikelronnau/google_scholar_paper_finder</a></p>
<h3>Analysis Notes</h3>
<p>Uses a locally modified <code>scholar</code> package. Pretty vanilla otherwise.</p>
<h2>ag-gipp/grespa: A tool to obtain and analyze data from Google Scholar</h2>
<p><a href="https://github.com/ag-gipp/grespa">https://github.com/ag-gipp/grespa</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>Uses <code>scrapy</code> package for Scholar access.</li>
<li>From the README:</li>
</ul>
<h4>GRESPA Scraper</h4>
<p>The spiders can be run locally (in the current shell) or using the <em>scrapyd</em> daemon. The following part describes the
local installation and configuration necessary to run the scrapy spiders.</p>
<h4>Dependencies</h4>
<p>Installation details are provided by the readme located in the projects root directory.</p>
<p>For the proxy connection a socks proxy (e.g. tor) can be used, together with a http proxy
to fire the actual requests against.</p>
<p>Recommended proxies:</p>
<ul>
<li>socks proxy: standard tor client</li>
<li>http proxy: <code>privoxy</code> or <code>polipo</code></li>
</ul>
<p>See <code>settings.py</code> for the appropriate http proxy port. If you do not want to use a proxy, you can disable the proxy
middleware in the scrapy settings.</p>
<h4>Configuration</h4>
<p>Environment variables (or crawler settings) are used to configure credentials like passwords or database connections.
The files <code>*.env-sample</code> contain all parameters that are currently used (with placeholders). To provide your values,
strip the suffix <code>-sample</code> from the files and fill in your values.
So the file <code>database.env</code> contains the correct postgres connection credentials. To actually use the values,
you can export the variables as <em>environment variables</em>.</p>
<h4>Tor Control</h4>
<p>The following config parameters are used to control the tor client using the built in class:</p>
<ul>
<li><code>TOR_CONTROL_PASSWORD=...</code></li>
</ul>
<h2>yufree/scifetch: webpage crawling tools for pubmed, google scholar and rss</h2>
<p><a href="https://github.com/yufree/scifetch">https://github.com/yufree/scifetch</a></p>
<h3>Analysis Notes</h3>
<p>Has two vanilla scrapers for Google Scholar and PubMed.</p>
<h2>pykong/PyperGrabber: Fetches PubMed article IDs (PMIDs) from email inbox, then crawls PubMed, Google Scholar and Sci-Hub for respective PDF files.</h2>
<p><a href="https://github.com/pykong/PyperGrabber">https://github.com/pykong/PyperGrabber</a></p>
<h3>PyperGrabber</h3>
<p>Fetches PubMed article IDs (PMIDs) from email inbox, then crawls <strong>PubMed</strong>, <strong>Google Scholar</strong> and <strong>Sci-Hub</strong> for respective PDF files.</p>
<p>PubMed can send you regular update on new articles matching your specified search criteria. PyperGrabber will automatically download thoe papers, saving you much time tracking on downloading those manually. When no PDF article is found PyperGrabber will save the PubMed abstract of the respective article to PDF. All files are named after PMID for convenience.</p>
<h4>NOTES:</h4>
<ul>
<li><em>Messy code ahead!</em></li>
<li>Program may halt without error message. The source of this bug is yet to be determined.</li>
<li>The web crawler function may be used to work with other sources of PMIDs then email (e.g. command line parameter  or file holding list of PMIDs)</li>
</ul>
<h2>pentas1150/google-scholar-keyword-crwaler: 구글 스칼라에서 논문 제목을 단어 단위로 쪼개어 단어 카운팅해주는 크롤러</h2>
<p><a href="https://github.com/pentas1150/google-scholar-keyword-crwaler">https://github.com/pentas1150/google-scholar-keyword-crwaler</a></p>
<h3>Translated README:</h3>
<p>I stopped due to the Google reCAPTCHA problem… Even with Beautifulsoup &amp; Selenium, it could not be solved well, so I am exploring another solution. It doesn’t show up again after a certain time. But if I turn it again, it blocks and it hurts.</p>
<h4>Brief explanation</h4>
<p>Graduate students will read a lot of thesis. I’m looking for papers on Google Scholar and I’m curious about recent research trends, but it’s hard to find one by one. So, by counting the words in the title of the paper by crawling, I created it to help understand the latest research trends. (We will continue to refine it.)</p>
<h3>Analysis Notes</h3>
<p>Uses <code>axios</code> npm package for URL querying Scholar, hence is pretty vanilla. JavaScript.</p>
<p>Scholar access code at <a href="https://github.com/pentas1150/google-scholar-keyword-crwaler/blob/master/crwal.js#L19">https://github.com/pentas1150/google-scholar-keyword-crwaler/blob/master/crwal.js#L19</a></p>
<h2>janosh/gatsby-source-google-scholar: Gatsby source plugin that pulls metadata for scientific publications from Google Scholar</h2>
<p><a href="https://github.com/janosh/gatsby-source-google-scholar">https://github.com/janosh/gatsby-source-google-scholar</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla scraper in JavaScript.</p>
<p>Has very clear and grokkable error messages: might be useful for that. <a href="https://github.com/janosh/gatsby-source-google-scholar/blob/master/scraper.js">https://github.com/janosh/gatsby-source-google-scholar/blob/master/scraper.js</a></p>
<h2>Nicozheng/GoogleScholarCrawler: search, format, and download paper form google scholar</h2>
<p><a href="https://github.com/Nicozheng/GoogleScholarCrawler">https://github.com/Nicozheng/GoogleScholarCrawler</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla scraper using Selenium driver and BeautifulSoup packages.</p>
<h2>zjuiuczy/Google-Scholar: cs411 project</h2>
<p><a href="https://github.com/zjuiuczy/Google-Scholar">https://github.com/zjuiuczy/Google-Scholar</a></p>
<h3>Analysis Notes</h3>
<p>Visualization project from local databases. <strong>Not a scraper!</strong></p>
<h2>fholstege/GoogleScholar_Research</h2>
<p><a href="https://github.com/fholstege/GoogleScholar_Research">https://github.com/fholstege/GoogleScholar_Research</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>Uses <code>scrapy</code> for Scholar access: <a href="https://github.com/fholstege/GoogleScholar_Research/blob/master/gscholar/spiders/gsspider.py">https://github.com/fholstege/GoogleScholar_Research/blob/master/gscholar/spiders/gsspider.py</a> &amp; <a href="https://github.com/fholstege/GoogleScholar_Research/blob/master/gscholar/gscholar_crawlprocess.py#L47">https://github.com/fholstege/GoogleScholar_Research/blob/master/gscholar/gscholar_crawlprocess.py#L47</a></li>
</ul>
<p>From the README:</p>
<h3>Retrieving data from Google Scholar for research</h3>
<p>(Currently in development)</p>
<p>This is repository is my attempt to make a tool that allows users to scrape data from profiles on GoogleScholar. This data will be put into a dataset that contains the following information:</p>
<ul>
<li>
<p>h-index - the h-index for the professor for all years</p>
</li>
<li>
<p>h5-index  - the h-index for the professor for the last five years</p>
</li>
<li>
<p>i10-index - the i10 index for the professor for all years</p>
</li>
<li>
<p>i10-5-index - the i10 index for the professor for the last five years</p>
</li>
<li>
<p>n_citations - the total number of citations</p>
</li>
<li>
<p>n5_citations  - the total number of citations for the last five years</p>
</li>
<li>
<p>institution - the institution of the profile user</p>
</li>
<li>
<p>name  - name of the profile user</p>
</li>
<li>
<p>url - link to the profile</p>
</li>
<li>
<p>field - using tags, we determine the field the profile is active in</p>
</li>
</ul>
<p>Users should be able to fill in their field of interest and the number of profiles they want to scrape. A first version of the scraper has already been used by students of Leiden and Oxford University.</p>
<h2>mattkearl/AdvancedSearchforGoogleScholar: Advanced Search for Google Scholar</h2>
<p><a href="https://github.com/mattkearl/AdvancedSearchforGoogleScholar">https://github.com/mattkearl/AdvancedSearchforGoogleScholar</a></p>
<p>From the README:</p>
<h3>An extension to help users expand their search queries on Google Scholar.</h3>
<p>The <strong>BEST</strong> advanced search for Google Scholar is finally here!</p>
<h4>What is Google Scholar Plus?</h4>
<p>Google Scholar Plus is an <strong>extension</strong> that helps users discover better search results. Where you can quickly explore related words that can narrow or broaden your search on Google Scholar.</p>
<p>Whether you are working on research, academic, or scholarly papers, Google Scholar Plus will help you explore words to narrow or broaden your search results – on the fly.  This easy to use extension will help college and university students create a better and more advanced searches for research and college papers.</p>
<p>Feeling stuck? Having a hard time coming up with the right search? Google Scholar Plus can also help by expanding your search by providing relevant search terms.</p>
<p>Google Scholar Plus can also help you discover articles similar to the search query you are currently using.</p>
<p>When you install Google Scholar Plus, Google Scholar will automatically update your related word options to customize your now advanced search query.</p>
<p>Google Scholar Plus was created and developed by university students and faculty FOR university students and faculty.</p>
<h2>hazelnutsgz/NaiveScholarMap: Interactive Visualization Of Google Scholar connection all past 20 years</h2>
<p><a href="https://github.com/hazelnutsgz/NaiveScholarMap">https://github.com/hazelnutsgz/NaiveScholarMap</a></p>
<h3>Analysis Notes</h3>
<p>Visualization tool.</p>
<p>From the README: “Google Scholar Connection visualized by echart”</p>
<h2>Robinlovelace/scholarsearch: Tiny R package that makes it easy to search for academic publications on Google Scholar from the command line</h2>
<p><a href="https://github.com/Robinlovelace/scholarsearch">https://github.com/Robinlovelace/scholarsearch</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla crawler in R</p>
<h2>TWRogers/google-scholar-export: Takes a Google Scholar profile URL and outputs an html snippet to add to your website.</h2>
<p><a href="https://github.com/TWRogers/google-scholar-export">https://github.com/TWRogers/google-scholar-export</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla scraper in Python.</p>
<p>From the README:</p>
<p><strong>google-scholar-export</strong> is a Python library for scraping Google scholar profiles to generate a HTML publication lists.</p>
<p>Currently, the profile can be scraped from either the Scholar user id, or the Scholar profile URL, resulting in a list
of the following:</p>
<ol>
<li>Publication title</li>
<li>Publication authors</li>
<li>Journal information (name, issue no., vol.)</li>
<li>Date</li>
<li>Url to the Scholar publication</li>
<li>The number of citations according to Scholar</li>
</ol>
<p>The resulting html is formatted like:</p>
<pre class="language-html"><code class="language-html"><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>p</span><span class="token punctuation">></span></span>Publications (<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>b</span><span class="token punctuation">></span></span>20<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>b</span><span class="token punctuation">></span></span>) last scraped for <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>a</span> <span class="token attr-name">href</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>https://scholar.google.co.uk/citations?user=JicYPdAAAAAJ&amp;hl=en<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>Geoffrey Hinton<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>a</span><span class="token punctuation">></span></span> on <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>b</span><span class="token punctuation">></span></span>2019-08-11<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>b</span><span class="token punctuation">></span></span> 
using <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>a</span> <span class="token attr-name">href</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>https://github.com/TWRogers/google-scholar-export<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>google-scholar-export<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>a</span><span class="token punctuation">></span></span>.<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>p</span><span class="token punctuation">></span></span>
<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>div</span> <span class="token attr-name">class</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>card<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>
    <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>div</span> <span class="token attr-name">class</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>card-publication<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>
        <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>div</span> <span class="token attr-name">class</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>card-body card-body-left<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>
            <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>h4</span><span class="token punctuation">></span></span><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>a</span> <span class="token attr-name">href</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>https://scholar.google.co.uk/citations?user=JicYPdAAAAAJ&amp;hl=en#d=gs_md_cita-d&amp;u=%2Fcitations%3Fview_op%3Dview_citation%26hl%3Den%26oe%3DASCII%26user%3DJicYPdAAAAAJ%26citation_for_view%3DJicYPdAAAAAJ%3AGFxP56DSvIMC<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>Learning internal representations by error-propagation<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>a</span><span class="token punctuation">></span></span><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>h4</span><span class="token punctuation">></span></span>
            <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>p</span><span class="token style-attr language-css"><span class="token attr-name"> <span class="token attr-name">style</span></span><span class="token punctuation">="</span><span class="token attr-value"><span class="token property">font-style</span><span class="token punctuation">:</span> italic<span class="token punctuation">;</span></span><span class="token punctuation">"</span></span><span class="token punctuation">></span></span>by DE Rumelhart, GE Hinton, RJ Williams<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>p</span><span class="token punctuation">></span></span>
            <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>p</span><span class="token punctuation">></span></span><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>b</span><span class="token punctuation">></span></span>Parallel Distributed Processing: Explorations in the Microstructure of …<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>b</span><span class="token punctuation">></span></span><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>p</span><span class="token punctuation">></span></span>
        <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>div</span><span class="token punctuation">></span></span>
    <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>div</span><span class="token punctuation">></span></span>
    <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>div</span> <span class="token attr-name">class</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>card-footer<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>
        <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>small</span> <span class="token attr-name">class</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>text-muted<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>Published in <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>b</span><span class="token punctuation">></span></span>1986<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>b</span><span class="token punctuation">></span></span> | 
        <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>a</span> <span class="token attr-name">href</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>https://scholar.google.co.uk/scholar?oi=bibs&amp;hl=en&amp;oe=ASCII&amp;cites=1374659557399191249,4574189560556662535,10453698013284960354,12541410141153091507,7476519782727404507,1722523513356915749,6822548856209813074,4464353390709992638,15344233312479649775<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>Citations: <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>b</span><span class="token punctuation">></span></span>62260<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>b</span><span class="token punctuation">></span></span><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>a</span><span class="token punctuation">></span></span><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>small</span><span class="token punctuation">></span></span>
    <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>div</span><span class="token punctuation">></span></span>
<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>div</span><span class="token punctuation">></span></span>
...
</code></pre>
<p>And is primarily aimed at people using Bootstrap.</p>
<p>It is possible to modify the html for each publication by modifying <code>PAPER_TEMPLATE</code> in <code>./exporter/exporter.py</code></p>
<h2>Rationale</h2>
<p>Generating lists of publications for static websites is a pain. Google Scholar, popular amongst academics, is great at
tracking publications and citations. However, it does not have an API.</p>
<p>There are some other libraries:</p>
<ul>
<li><a href="https://github.com/dschreij/scholar_parser">dschreij/scholar_parser</a></li>
<li><a href="https://github.com/bborrel/google-scholar-profile-parser">bborrel/google-scholar-profile-parser</a></li>
</ul>
<p>However, both of these are php based, and not useful for static sites.</p>
<p>The purpose of this repository is to allow generation of static html code directly from your Google Scholar profile.
This code can be run manually, or at website build time to update the publications list.</p>
<p>Here is an example that utilises this library:
<a href="https://twrogers.github.io/projects.html#publications">twrogers.github.io/projects.html</a></p>
<h2>Ir1d/PKUScholar: A naive Google Scholar for PKU CS</h2>
<p><a href="https://github.com/Ir1d/PKUScholar">https://github.com/Ir1d/PKUScholar</a></p>
<h3>Analysis Notes</h3>
<p>Uses <code>scholarly</code> package: <a href="https://github.com/Ir1d/PKUScholar/blob/master/crawler/crawler.py">https://github.com/Ir1d/PKUScholar/blob/master/crawler/crawler.py</a></p>
<h2>leyiwang/nlp_research: The Research Spider for Anthology.</h2>
<p><a href="https://github.com/leyiwang/nlp_research">https://github.com/leyiwang/nlp_research</a></p>
<p>This toolkit can automatically grab the papers information by given keywords in title. You can set the search params: the conference, publication date and the keywords in title . Then it will automatically save these papers’ title, authors, download link, Google Scholar cited number and abstracts information in a Excel file.</p>
<h3>Analysis Notes</h3>
<p>Uses Selenium driver approach.</p>
<h2>tyiannak/pyScholar: Python Library to Analyse and Visualise Google Scholar Metadata</h2>
<p><a href="https://github.com/tyiannak/pyScholar">https://github.com/tyiannak/pyScholar</a></p>
<h3>Analysis Notes</h3>
<p>Uses <code>scholarly</code> package.</p>
<h2>lyn716/CitationsGenerator: for generating cite relation of articles in google scholar</h2>
<p><a href="https://github.com/lyn716/CitationsGenerator">https://github.com/lyn716/CitationsGenerator</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>uses SOCKS5 proxies, etc.: <a href="https://github.com/lyn716/CitationsGenerator/blob/master/crawl_tools/request_with_proxy.py">https://github.com/lyn716/CitationsGenerator/blob/master/crawl_tools/request_with_proxy.py</a></li>
<li>uses UserAgent spoofing: <a href="https://github.com/lyn716/CitationsGenerator/blob/master/crawl_tools/ua_pool.py">https://github.com/lyn716/CitationsGenerator/blob/master/crawl_tools/ua_pool.py</a></li>
<li>has code on board for Selenium driver, but I don’t see it used (yet).</li>
<li>Scholar access: <a href="https://github.com/lyn716/CitationsGenerator/blob/master/GoogleInfoGenerator.py">https://github.com/lyn716/CitationsGenerator/blob/master/GoogleInfoGenerator.py</a></li>
<li>Tor proxy check: <a href="https://github.com/lyn716/CitationsGenerator/blob/master/tor_test.py">https://github.com/lyn716/CitationsGenerator/blob/master/tor_test.py</a></li>
</ul>
<h2>alvinwan/webfscholar: Generate publications webpage from a google scholar</h2>
<p><a href="https://github.com/alvinwan/webfscholar">https://github.com/alvinwan/webfscholar</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>
<p>Vanilla crawler: <a href="https://github.com/alvinwan/webfscholar/blob/master/webfscholar/profile.py">https://github.com/alvinwan/webfscholar/blob/master/webfscholar/profile.py</a></p>
</li>
<li>
<p>But has some extra bits that may be of interest at the biTeX level. From the README:</p>
<h4>Why webfscholar</h4>
<p>The intermediate bibtex allows you to plug-and-play with other
auto-publication-webpage services. Furthermore, unlike most Google Scholar
unofficial APIs, this library:</p>
<ul>
<li>Uses information pulled directly from the Google Scholar profile page, as
opposed to un-configurable search results. This means <code>webfscholar</code> will
respect any custom titles or removed publications.</li>
<li>Supplants Google Scholar information using ArXiv.</li>
</ul>
</li>
</ul>
<h2>troore/scholar-spider: A spider to get researcher information, citations, etc. from academic libraries like IEEE digital library, google scholar, microsoft academic, etc.</h2>
<p><a href="https://github.com/troore/scholar-spider">https://github.com/troore/scholar-spider</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>Vanilla crawler</li>
<li>uses <a href="http://scholar.glgoo.org/scholar">http://scholar.glgoo.org/scholar</a> which redirects to Microsoft Bing these days instead (August 2020)</li>
<li><a href="https://github.com/troore/scholar-spider/blob/master/getcitation.py">https://github.com/troore/scholar-spider/blob/master/getcitation.py</a></li>
</ul>
<h2>miostudio/DawnScholar: A scholar search for The People who cannot access google scholar freely.</h2>
<p><a href="https://github.com/miostudio/DawnScholar">https://github.com/miostudio/DawnScholar</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>
<p>vanilla crawler: <a href="https://github.com/miostudio/DawnScholar/blob/master/gs.php">https://github.com/miostudio/DawnScholar/blob/master/gs.php</a></p>
</li>
<li>
<p>From the README:</p>
<p>For those who need scholar search in mainland China.</p>
<p>url：<a href="http://a.biomooc.com/">http://a.biomooc.com/</a></p>
<p>local: <a href="http://scholar.wjl.com/">http://scholar.wjl.com/</a></p>
</li>
</ul>
<h2>chrokh/lit: Command line tool for systematic literature reviews using Google Scholar</h2>
<p><a href="https://github.com/chrokh/lit">https://github.com/chrokh/lit</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>Uses Selenium driver together with JavaScript code: this is interesting as all the other Selenium driver users were coded in Python or PHP.</li>
<li>knows about and seems to attempt to handle RECAPTCHA, etc. Scholar nuisances: <a href="https://github.com/chrokh/lit/blob/master/src/scholar.js">https://github.com/chrokh/lit/blob/master/src/scholar.js</a></li>
<li>To be inspected further…</li>
</ul>
<h2>HTian1997/getarticle: getarticle is a package based on SciHub and Google Scholar that can download articles given DOI, website address or keywords.</h2>
<p><a href="https://github.com/HTian1997/getarticle">https://github.com/HTian1997/getarticle</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla downloader.</p>
<h2>fagnersutel/Google_Scholar: Google Scholar</h2>
<p><a href="https://github.com/fagnersutel/Google_Scholar">https://github.com/fagnersutel/Google_Scholar</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>Vanilla crawler</li>
<li>Check the queries: this one includes a call to fetch the <em>abstract</em> of a paper from Scholar, f.e.. <a href="https://github.com/fagnersutel/Google_Scholar/blob/master/google_scholar.R#L69">https://github.com/fagnersutel/Google_Scholar/blob/master/google_scholar.R#L69</a></li>
</ul>
<h2>tugcelmaci/GoogleScholarWebScraping: Google Scholar Web Scraping</h2>
<p><a href="https://github.com/tugcelmaci/GoogleScholarWebScraping">https://github.com/tugcelmaci/GoogleScholarWebScraping</a></p>
<h3>Analysis Notes</h3>
<p>multiple egotrip app. Vanilla.</p>
<h2>guzmonne/scholar: Google Scholar web scrapper</h2>
<p><a href="https://github.com/guzmonne/scholar">https://github.com/guzmonne/scholar</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla.</p>
<h2>arunhpatil/GoogleScholar: Revised GoogleScholar-API from fredrike</h2>
<p><a href="https://github.com/arunhpatil/GoogleScholar">https://github.com/arunhpatil/GoogleScholar</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>Vanilla scraper in PHP</li>
<li><a href="https://github.com/arunhpatil/GoogleScholar/blob/master/GoogleScholar.php#L16">https://github.com/arunhpatil/GoogleScholar/blob/master/GoogleScholar.php#L16</a></li>
</ul>
<h2>ChenZhongPu/GoogleScholar: This is an extension for PopClip to search in a China’s google scholar mirror site</h2>
<p><a href="https://github.com/ChenZhongPu/GoogleScholar">https://github.com/ChenZhongPu/GoogleScholar</a></p>
<h2>jiamings/scholar-bibtex-keys: Convert bibtex keys to Google scholar style: [first-author-last-name][year][title-first-word]</h2>
<p><a href="https://github.com/jiamings/scholar-bibtex-keys">https://github.com/jiamings/scholar-bibtex-keys</a></p>
<h2>lovit/google_scholar_citation_keywords: Google scholar citation keyword</h2>
<p><a href="https://github.com/lovit/google_scholar_citation_keywords">https://github.com/lovit/google_scholar_citation_keywords</a></p>
<h2>dtczhl/dtc-google-scholar-helper: Google Scholar Helper</h2>
<p><a href="https://github.com/dtczhl/dtc-google-scholar-helper">https://github.com/dtczhl/dtc-google-scholar-helper</a></p>
<h2>Andorreta/ScholarCrawler: Google Scholar Crawler</h2>
<p><a href="https://github.com/Andorreta/ScholarCrawler">https://github.com/Andorreta/ScholarCrawler</a></p>
<h2>jjsantanna/google_scholar_crawler: Google Scholar Crawler</h2>
<p><a href="https://github.com/jjsantanna/google_scholar_crawler">https://github.com/jjsantanna/google_scholar_crawler</a></p>
<h2>calebchiam/GoogleScholarScraper: Uses Python scholarly package to scrape relevant articles with given search terms, and then filters by title</h2>
<p><a href="https://github.com/calebchiam/GoogleScholarScraper">https://github.com/calebchiam/GoogleScholarScraper</a></p>
<h2>MJHutchinson/GoogleScholarWebscraping: Utility to scrape google scholar for citation data</h2>
<p><a href="https://github.com/MJHutchinson/GoogleScholarWebscraping">https://github.com/MJHutchinson/GoogleScholarWebscraping</a></p>
<h2>HilaryTraut/GoogleScholar_MetaAnalysis: A collection of simple scripts for retrieving citation information from a Google Scholar search.</h2>
<p><a href="https://github.com/HilaryTraut/GoogleScholar_MetaAnalysis">https://github.com/HilaryTraut/GoogleScholar_MetaAnalysis</a></p>
<h2>idchuem/googleScholar-ParsingBot</h2>
<p><a href="https://github.com/idchuem/googleScholar-ParsingBot">https://github.com/idchuem/googleScholar-ParsingBot</a></p>
<h2>gursidak/web_scrapping_googleScholar</h2>
<p><a href="https://github.com/gursidak/web_scrapping_googleScholar">https://github.com/gursidak/web_scrapping_googleScholar</a></p>
<h2>juicecwc/GoogleScholarCrawler</h2>
<p><a href="https://github.com/juicecwc/GoogleScholarCrawler">https://github.com/juicecwc/GoogleScholarCrawler</a></p>
<h2>foool/GoogleScholarBibTex: Batch get BibTeXs of papers collected in your Google Scholar library.</h2>
<p><a href="https://github.com/foool/GoogleScholarBibTex">https://github.com/foool/GoogleScholarBibTex</a></p>
<h2>michaelvdow/GoogleScholarScript</h2>
<p><a href="https://github.com/michaelvdow/GoogleScholarScript">https://github.com/michaelvdow/GoogleScholarScript</a></p>
<h2>Sharmelen/google_scholar: Extract data from google scholar</h2>
<p><a href="https://github.com/Sharmelen/google_scholar">https://github.com/Sharmelen/google_scholar</a></p>
<h2>maximusKarlson/google-scholar: Sort google scholar results by citations.</h2>
<p><a href="https://github.com/maximusKarlson/google-scholar">https://github.com/maximusKarlson/google-scholar</a></p>
<h2>Xotic-Knight/Google_Scholar</h2>
<p><a href="https://github.com/Xotic-Knight/Google_Scholar">https://github.com/Xotic-Knight/Google_Scholar</a></p>
<h2>smakonin/ScholarHacks: Scripts for hacking Google Scholar HTML pages.</h2>
<p><a href="https://github.com/smakonin/ScholarHacks">https://github.com/smakonin/ScholarHacks</a></p>
<h2>nivgold/SCholar: Nice tool to get useful authors information from google scholar. wraps the scholarly package.</h2>
<p><a href="https://github.com/nivgold/SCholar">https://github.com/nivgold/SCholar</a></p>
<h2>mehdi-user/ScholarChart: ScholarChart: a charting userscript for Google Scholar</h2>
<p><a href="https://github.com/mehdi-user/ScholarChart">https://github.com/mehdi-user/ScholarChart</a></p>
<h2>mehdi-user/ScholarChart: ScholarChart: a charting userscript for Google Scholar</h2>
<p><a href="https://github.com/mehdi-user/ScholarChart">https://github.com/mehdi-user/ScholarChart</a></p>
<h2>meander-why/konbini: crawler for google scholar</h2>
<p><a href="https://github.com/meander-why/konbini">https://github.com/meander-why/konbini</a></p>
<h3>Analysis Notes</h3>
<p>Uses its own vanilla crawler code. No error handling, nothing fancy.</p>
<h2>ViGeng/gs_spider: Google Scholar Spider</h2>
<p><a href="https://github.com/ViGeng/gs_spider">https://github.com/ViGeng/gs_spider</a></p>
<h3>Analysis Notes</h3>
<p>Uses Selenium driver based headless browser plus BeautifulSoup to fetch and crawl Scholar pages. Code is in <a href="https://github.com/ViGeng/gs_spider/blob/master/util/CitationGetter.py">https://github.com/ViGeng/gs_spider/blob/master/util/CitationGetter.py</a> + <a href="https://github.com/ViGeng/gs_spider/blob/master/util/Browser.py">https://github.com/ViGeng/gs_spider/blob/master/util/Browser.py</a> – nothing fancy beyond that.</p>
<p>Google Translation of README hints that they’re considering delays / timeouts, but I don’t see anything important implemented of that TODO list.</p>
<h2>sraashis/scholary: Scrap google scholar</h2>
<p><a href="https://github.com/sraashis/scholary">https://github.com/sraashis/scholary</a></p>
<h3>Analysis Notes</h3>
<p>Edit/Copy of scholarly. (Not forked)</p>
<h2>devteamepic/scholar-parser: Parser for google scholar</h2>
<p><a href="https://github.com/devteamepic/scholar-parser">https://github.com/devteamepic/scholar-parser</a></p>
<h3>Analysis Notes</h3>
<p>Edit/Copy of scholarly plus some extraction code, but nothing essential added to scholarly pops out in the initial inspection. (Not forked)</p>
<h2>charlesduan/scholar2tex: Convert Google Scholar cases to LaTeX</h2>
<p><a href="https://github.com/charlesduan/scholar2tex">https://github.com/charlesduan/scholar2tex</a></p>
<h3>Analysis Notes</h3>
<p>Processes downloaded / already fetched Scholar HTML pages.</p>
<p>From the README:</p>
<h4>scholar2tex</h4>
<p>Converts HTML for cases from Google Scholar into LaTeX. The resulting file is
formatted based on casemacs.sty, which will generate half-letter-size sheets
that can be compiled into a book.</p>
<p><strong>scholar2tex.rb</strong> - script that converts an HTML page of a Google Scholar case into
a LaTeX document.</p>
<h2>Bearzilasaur/ScholarScraper: Repository for a Google Scholar scraper for literature reviews.</h2>
<p><a href="https://github.com/Bearzilasaur/ScholarScraper">https://github.com/Bearzilasaur/ScholarScraper</a></p>
<h3>Analysis Notes</h3>
<p>While the requirements file lists <code>scholarly</code> as a dependency, it seems the code doesn’t use it (yet), but does vanilla URL queries and feeds the HTML to BeautifulSoup for data extraction.</p>
<p>Includes a Scopus scraper as well, but this one is vanilla as well and there’s mention of it in TODO so I wonder if the quick code inspection discovered a not-yet-working Scopus scraper?</p>
<h2>dilumb/scholarlyPull: Pull author details and papers from Google Scholar</h2>
<p><a href="https://github.com/dilumb/scholarlyPull">https://github.com/dilumb/scholarlyPull</a></p>
<h3>Analysis Notes</h3>
<p>From the README:</p>
<p>Pull author details and papers from Google Scholar. <strong>This tool is build on top of <code>scholarly</code>. Go through <code>scholarly-README.rst</code> for details on how to use scholarly for your need.</strong></p>
<p>That .rst file seems to be a copy of the <code>scholarly</code> README so nothing special.</p>
<h2>toolbuddy/ScholarJS: A parser for Google Scholar, written in JavaScript.</h2>
<p><a href="https://github.com/toolbuddy/ScholarJS">https://github.com/toolbuddy/ScholarJS</a></p>
<h3>Analysis Notes</h3>
<p>From the README:</p>
<p>I will always strive to add features that increase the power of this API, <strong>but I will never add features that intentionally try to work around the query limits imposed by Google Scholar. Please don’t ask me to add such features.</strong></p>
<h2>alegione/ScholarPlot: Shiny web tool for visualising and exporting google scholar data</h2>
<p><a href="https://github.com/alegione/ScholarPlot">https://github.com/alegione/ScholarPlot</a></p>
<h3>Analysis Notes</h3>
<p>Pretty useless as it’s for listing your own publications only. Let’s label this type of app ‘egotrip’ for I expect to run into more incantations of this sort of thing and I don’t want to spend time writing up analysis notes for each.</p>
<p>From the README:</p>
<p>The input is your Google Scholar ID. You can find this in your Google Scholar web address. If you go to your scholar profile, your individual ID can be found as part of the web address.</p>
<p>(Example URL)</p>
<p>In the above example, my user ID is highlighted (i.e. rW9T5f4AAAAJ).</p>
<p>The current primary output is a plot of papers per year and citations per year, a secondary output is a table of the publications of the author to date, ordered by ‘Paper Score’: A custom metric that aims to take into account impact factor of the journal and the number of citations per year of the manuscript itself. This can be helpful for applications that ask for you to provide your ‘top 10 papers’.</p>
<h2>tihbe/google_scholar_trend: A simple scientific paper based trend viewer using the number of results in Google Scholar.</h2>
<p><a href="https://github.com/tihbe/google_scholar_trend">https://github.com/tihbe/google_scholar_trend</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla URL querying.</p>
<h2>brunojus/google-scholar-crawler</h2>
<p><a href="https://github.com/brunojus/google-scholar-crawler">https://github.com/brunojus/google-scholar-crawler</a></p>
<h3>Analysis Notes</h3>
<p>Selenium driver based Scholar URL querying.</p>
<h2>siwalan/google-scholar-citation-scrapper: Simple scrapper for Google Scholar Data</h2>
<p><a href="https://github.com/siwalan/google-scholar-citation-scrapper">https://github.com/siwalan/google-scholar-citation-scrapper</a></p>
<h3>Analysis Notes</h3>
<p>egotrip style app. Vanilla code.</p>
<p>From the README:</p>
<p>This is a simple scrapper for Google Scholar Data, you can input a Google Scholar ID and it will return all the publications related to the said ID and citation data for the last 3 years. You can easily modify it to get data from only the last year, last five years, or all years the publication has been cited.</p>
<p>The program works by inputing a list of Google Scholar ID on the file called dosen.csv (you can change the file name, to add/remove scholars please just add or remove data in the row) and running all the ipynb cell. The ipynb will create a .xlsx file as the result containing all the publication from the said Google Scholar ID and the citations data for the last 3 years.</p>
<h2>lucgerrits/google-scholar-scraper: Basic Google Scholar scraper written in python.</h2>
<p><a href="https://github.com/lucgerrits/google-scholar-scraper">https://github.com/lucgerrits/google-scholar-scraper</a></p>
<h3>Analysis Notes</h3>
<p>Selenium driver based Scholar URL querying.</p>
<h2>madhawadias/google-scholar-profile-scraper: Scrape profiles of google scholar authors.</h2>
<p><a href="https://github.com/madhawadias/google-scholar-profile-scraper">https://github.com/madhawadias/google-scholar-profile-scraper</a></p>
<h3>Analysis Notes</h3>
<p>Uses <a href="https://github.com/scrapy/scrapy"><code>scrapy.http</code> package</a> for the Google Scholar scraping.</p>
<h2>gerryreilly/google_scholar_scrape: Sample code for scraping list of publication for a group of authors and saving in a csv file</h2>
<p><a href="https://github.com/gerryreilly/google_scholar_scrape">https://github.com/gerryreilly/google_scholar_scrape</a></p>
<h3>Analysis Notes</h3>
<p>Uses <code>scholarly</code>.</p>
<h2>SakuraX99/Crawler-For-Google-Scholar</h2>
<p><a href="https://github.com/SakuraX99/Crawler-For-Google-Scholar">https://github.com/SakuraX99/Crawler-For-Google-Scholar</a></p>
<h3>Analysis Notes</h3>
<p>Uses <code>scholarly</code> and <a href="https://pypi.org/project/free-proxy/"><code>fp</code> (FreeProxy)</a> to get the stuff. Clearly is a scratch project but might be handy to have a quick peek at it.</p>
<h2>WebGuruBoy/Python-google-scholar-scraping</h2>
<p><a href="https://github.com/WebGuruBoy/Python-google-scholar-scraping">https://github.com/WebGuruBoy/Python-google-scholar-scraping</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>
<p>uses Selenium driver based headless browser for Scholar URL querying</p>
</li>
<li>
<p>implements ‘adaptive request rate’ in <a href="https://github.com/WebGuruBoy/Python-google-scholar-scraping/blob/master/new_scholar.py#L69">https://github.com/WebGuruBoy/Python-google-scholar-scraping/blob/master/new_scholar.py#L69</a></p>
</li>
<li>
<p>From their <a href="https://github.com/WebGuruBoy/Python-google-scholar-scraping/blob/master/scholar.py">https://github.com/WebGuruBoy/Python-google-scholar-scraping/blob/master/scholar.py</a> ChangeLog:</p>
<p>2.11:  The Scholar site seems to have become more picky about the
number of results requested. The default of 20 in <a href="http://scholar.py">scholar.py</a>
could cause HTTP 503 responses. <a href="http://scholar.py">scholar.py</a> now doesn’t request
a maximum unless you provide it at the comment line. (For the
time being, you still cannot request more than 20 results.)</p>
</li>
</ul>
<p>Looks like (very) recent work done based on <code>scholar</code> package copy plus extras. Deserves a further peek beyond my initial scan.</p>
<h2>amychan331/google-scholar-scraper: Scraps scientific article data from Google Scholar and either create or update a node.</h2>
<p><a href="https://github.com/amychan331/google-scholar-scraper">https://github.com/amychan331/google-scholar-scraper</a></p>
<h3>Analysis Notes</h3>
<p><code>curl</code> + PHP based vanilla scraper.</p>
<h2>zhivou/google-scholar-helper: A simple gem to show information for 1 user from google scholar page</h2>
<p><a href="https://github.com/zhivou/google-scholar-helper">https://github.com/zhivou/google-scholar-helper</a></p>
<h3>Analysis Notes</h3>
<p>Ruby language tool, which uses the <a href="https://github.com/lostisland/faraday"><code>faraday</code> module</a> for Scholar access. From a very quick scan of that one (plus this codebase) the preliminary conclusion is: “yet another vanilla Scholar scraper”.</p>
<h2>liusida/Google-Scholar-Trends: Plot the trends of terminologies in Google Scholar over 20 years</h2>
<p><a href="https://github.com/liusida/Google-Scholar-Trends">https://github.com/liusida/Google-Scholar-Trends</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>
<p>uses a full set of faked headers (FireFox) to access the Scholar site: see <a href="https://github.com/liusida/Google-Scholar-Trends/blob/master/Google-Scholar-Trends.ipynb">https://github.com/liusida/Google-Scholar-Trends/blob/master/Google-Scholar-Trends.ipynb</a> near the top.</p>
</li>
<li>
<p>warns about Scholar: 2 secondd dealy between requests is advised in the README.</p>
</li>
</ul>
<h2>erkamozturk/Python-Google-Scholar</h2>
<h3>README</h3>
<p>Publications of faculty members at a university are usually published on university web pages. As an example, publications of SEHIR’s CS faculty members are published at their profile pages (e.g., see Ahmet Bulut’s publications at <a href="http://cs.sehir.edu.tr/en/profile/6/Ahmet-Bulut/">http://cs.sehir.edu.tr/en/profile/6/Ahmet-Bulut/</a>). However, searching for particular publications is not usually possible on such web pages.</p>
<p>In this project, you are going to develop a publication search engine (similar to Google Scholar) that will allow searching for publications of CS faculty members with some optional filters. Details regarding the requirements are as follows:
<a href="https://github.com/erkamozturk/Python-Google-Scholar">https://github.com/erkamozturk/Python-Google-Scholar</a></p>
<h3>Analysis Notes</h3>
<p>Don’t see nothing fancy. Vanilla crawl?</p>
<h2>mibot/Google-Scholar-Crawler</h2>
<p><a href="https://github.com/mibot/Google-Scholar-Crawler">https://github.com/mibot/Google-Scholar-Crawler</a></p>
<h3>Analysis Notes</h3>
<p>Has pretty basic Scholar scraper. Plus a CiteSeerX scraper.</p>
<p>Most work in here is about language detection, translation? (there’s an OAuth2-based google translate service being used?) and keyword analysis.</p>
<h2>chponte/google-scholar-search-engine</h2>
<p><a href="https://github.com/chponte/google-scholar-search-engine">https://github.com/chponte/google-scholar-search-engine</a></p>
<h3>Analysis Notes</h3>
<p>Extremely basic.</p>
<p>From the README:</p>
<p>This <em>extension</em> adds a search engine to Firefox.</p>
<h2>DaiJunyan/RutgersGoogleScholar</h2>
<p><a href="https://github.com/DaiJunyan/RutgersGoogleScholar">https://github.com/DaiJunyan/RutgersGoogleScholar</a></p>
<h3>Analysis Notes</h3>
<p>Looks like a rough copy &amp; edit work. Uses <code>scrapy</code> and the Selenium driver approach to access Scholar.</p>
<h2>JackXuRepo/Google-Scholar-Data-Scrapper: Developed a program, which reads and analyzes the contents of the Google Scholar Page of an author</h2>
<p><a href="https://github.com/JackXuRepo/Google-Scholar-Data-Scrapper">https://github.com/JackXuRepo/Google-Scholar-Data-Scrapper</a></p>
<h3>Analysis Notes</h3>
<p>Useless. Parses locally stored copies of HTML pages obtained from Google. Java.</p>
<h2>JohnZhang-source/download_google_scholar_alert: download papers in google scholar alert</h2>
<p><a href="https://github.com/JohnZhang-source/download_google_scholar_alert">https://github.com/JohnZhang-source/download_google_scholar_alert</a></p>
<h3>Analysis Notes</h3>
<p>Uses <a href="https://f.glgoo.top/scholar">https://f.glgoo.top/scholar</a> which (in my test) redirects to the Microsoft Bing search engine at the time of this writing (August 2020).</p>
<p>Uses User-Agent header and cookies. See <a href="https://github.com/JohnZhang-source/download_google_scholar_alert/blob/master/download%20paper%20in%20google%20scholar%20alert.py#L117">https://github.com/JohnZhang-source/download_google_scholar_alert/blob/master/download paper in google scholar alert.py#L117</a></p>
<h2>yokotatsuya/ExtractGoogleScholarCitations</h2>
<p>The matlab code to extract the list of publications of a personal author from Google Scholar Citations from only url (user id). Text Analytics toolbox is necessary.
<a href="https://github.com/yokotatsuya/ExtractGoogleScholarCitations">https://github.com/yokotatsuya/ExtractGoogleScholarCitations</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla access.</p>
<h2>paulazoo/google-scholar-h-index</h2>
<p>Some authors don’t have a Google Scholar stats page. This calculates an author’s h index based on citation and publication data from Google Scholar.
<a href="https://github.com/paulazoo/google-scholar-h-index">https://github.com/paulazoo/google-scholar-h-index</a></p>
<h3>Analysis Notes</h3>
<p>Selenium driver based.</p>
<h2>BAEM1N/google-scholar-crawler: with HYU or without HYU</h2>
<p><a href="https://github.com/BAEM1N/google-scholar-crawler">https://github.com/BAEM1N/google-scholar-crawler</a></p>
<h3>Analysis Notes</h3>
<p>With or without Selenium driver? Nothing fancy or new, anyway.</p>
<h2>Ngogabill/About-Google-Scholar</h2>
<p><a href="https://github.com/Ngogabill/About-Google-Scholar">https://github.com/Ngogabill/About-Google-Scholar</a></p>
<h3>Analysis Notes</h3>
<p>From the README:</p>
<p>This project consists of building a webpage similar to the original webpage of About google scholar . heres where u can find the orginal site.</p>
<h2>lorenzibex/Scrape-Google-Scholar: In this short python script you will see, how to extract/scrape these two parameters in Python.</h2>
<p><a href="https://github.com/lorenzibex/Scrape-Google-Scholar">https://github.com/lorenzibex/Scrape-Google-Scholar</a></p>
<h3>Analysis Notes</h3>
<p>Simple <code>scholarly</code> usage demo.</p>
<h2>VikramTiwari/google-scholarr-metadata-extraction</h2>
<p><a href="https://github.com/VikramTiwari/google-scholarr-metadata-extraction">https://github.com/VikramTiwari/google-scholarr-metadata-extraction</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla scraper, which grabs the BibTeX record from Scholar. <strong>JavaScript code</strong>. <a href="https://github.com/VikramTiwari/google-scholarr-metadata-extraction/blob/master/index.js">https://github.com/VikramTiwari/google-scholarr-metadata-extraction/blob/master/index.js</a></p>
<h2>utkarshsingh341/web-scraping-google-scholar: Web Scraping and Data Aquisition from Google Scholar</h2>
<p><a href="https://github.com/utkarshsingh341/web-scraping-google-scholar">https://github.com/utkarshsingh341/web-scraping-google-scholar</a></p>
<h2>pranjaljo/Google-Scholar-Network-Analysis</h2>
<p><a href="https://github.com/pranjaljo/Google-Scholar-Network-Analysis">https://github.com/pranjaljo/Google-Scholar-Network-Analysis</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla scraper</p>
<h2>istex/istex-google-scholar: A module for generating ISTEX holding description for Google Scholar Library Links</h2>
<p><a href="https://github.com/istex/istex-google-scholar">https://github.com/istex/istex-google-scholar</a></p>
<h3>Analysis Notes</h3>
<p>Very different purpose. Is an XSLT processor at its core.</p>
<p>From the README:</p>
<h4>Description</h4>
<p>Google Scholar allows the integration of OpenURL <abbr title="[object Object]">links</abbr> to full text resources contextualized with the electronic subscriptions associated to a given affiliation.</p>
<p>The integration of these <abbr title="[object Object]">links</abbr> to ISTEX resources follows these steps:</p>
<ol>
<li><strong>Description of the ISTEX holding</strong> thanks to Kbart files available with the BACON services (provided by ABES) in JSON and XML format. For example:</li>
</ol>
<ul>
<li>to get the complete list of packages available in BACON in json:</li>
</ul>
<p><a href="https://bacon.abes.fr/list.json">https://bacon.abes.fr/list.json</a></p>
<ul>
<li>to get the description of a particular package in XML format :</li>
</ul>
<p><a href="https://bacon.abes.fr/package2kbart/NPG_FRANCE_ISTEXJOURNALS.xml">https://bacon.abes.fr/package2kbart/NPG_FRANCE_ISTEXJOURNALS.xml</a></p>
<ol start="2">
<li><strong>Converting the ISTEX holding description</strong> from the Kbart XML format into the Google Scholar XML format defined at the following link :
<a href="https://scholar.google.com/intl/en/scholar/institutional_holdings.xml">https://scholar.google.com/intl/en/scholar/institutional_holdings.xml</a></li>
</ol>
<p>This is done by an XSLT style sheet applied to the Kbart files obtained via BACON for each ISTEX package.</p>
<ol start="3">
<li><strong>Creation of the Google Scholar form</strong> for requesting the activation of the OpenURL <abbr title="[object Object]">links</abbr>, also in XML :
<a href="https://scholar.google.com/intl/en/scholar/institutional_links.xml">https://scholar.google.com/intl/en/scholar/institutional_<abbr title="[object Object]">links</abbr>.xml</a></li>
</ol>
<p>This form will refer to the XML documents created at the step 2.</p>
<p>The files <code>institutional_links.xml</code> and <code>institutional_holdings.xml</code> for ISTEX can be validated by the dedicated DTD provided by Google.</p>
<ol start="4">
<li><strong>Submission of the form</strong>. The Google Scholar XML documents describing the holding in XML format are exposed on a web server. The URL of the main filled form file (<code>institutional_links.xml</code>) is sent by email to Google Scholar via their  address for support:
<a href="https://support.google.com/scholar/contact/general">https://support.google.com/scholar/contact/general</a></li>
</ol>
<p>Google Scholar indicates that the activation (and update) takes one to two weeks.</p>
<ol start="5">
<li><strong>Activation</strong> :</li>
</ol>
<p>After the setting by the user of his ISTEX affiliation in the Google Scholar settings, the <abbr title="[object Object]">links</abbr> to the ISTEX full texts will appear on the right side of the search results, for instance :</p>
<p><img src="doc/gs.png" alt="Example of links to full texts contextualized by the affiliation on Google Scholar"></p>
<ol start="6">
<li>
<p><strong>Update</strong> : the ISTEX holding description files can be regenerated by following the previous steps. It is only needed to replace the XML files exposed on internet and the Google Scholar crawler will take into account the new versions.</p>
</li>
<li>
<p>Here are some additional possible complementary elements doable by the <a href="https://github.com/istex/istex-browser-addon">ISTEX Browser Addon</a> :</p>
</li>
</ol>
<ul>
<li>
<p>Automatic setting of the <em>library <abbr title="[object Object]">links</abbr></em> affiliation in Google Scholar</p>
</li>
<li>
<p>Standard “button” for accessing the ISTEX full texts (actually it’s not really a button, simply decorated text easier to catch for a user and faster to render than bitmap) instead of the default Google Scholar text link, in order to have a consistent visual indication independently from the visited web site.</p>
</li>
</ul>
<h4>Build and run</h4>
<p>The goal of the present <em>node.js</em> module is to automate all the previously described steps in one single command line.
For updating the Google Scholar library <abbr title="[object Object]">links</abbr> and the different settings, simply re-execute the module.</p>
<h2>Coldflyer/Google-Scholar-Breadcrumbs-Builder</h2>
<p><a href="https://github.com/Coldflyer/Google-Scholar-Breadcrumbs-Builder">https://github.com/Coldflyer/Google-Scholar-Breadcrumbs-Builder</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla scraper. <a href="https://github.com/Coldflyer/Google-Scholar-Breadcrumbs-Builder/blob/master/ScrapingGS.py#L15">https://github.com/Coldflyer/Google-Scholar-Breadcrumbs-Builder/blob/master/ScrapingGS.py#L15</a></p>
<h2>wl8837/Google-Scholar-API</h2>
<p><a href="https://github.com/wl8837/Google-Scholar-API">https://github.com/wl8837/Google-Scholar-API</a></p>
<h3>Analysis Notes</h3>
<p>Uses Selenium driver approach.</p>
<p>TODO from the README:</p>
<p>Proxy and Tor: Not fullfilled. Google can identify robots even if I use proxy and Tor.</p>
<h2>vignif/crawler-google-scholar: Download automatically statistics and pictures from google scholar’s researchers.</h2>
<p><a href="https://github.com/vignif/crawler-google-scholar">https://github.com/vignif/crawler-google-scholar</a></p>
<h3>Analysis Notes</h3>
<p>Uses vanilla approach, but mentions <code>scholarly</code> as a potential way forward. Might be interesting anyway as this one collects author data from Scholar; pretty neat code.</p>
<p>From the README:</p>
<p>this repo presents an automatic way of downloading statistics of a set of researchers or professors from the google scholar.
giving as input a list of [name surname] of researchers it retrieves data from google scholar such as {# of publications, h-index, i10-index and others}</p>
<p>the project scholarly (<a href="https://pypi.org/project/scholarly/">https://pypi.org/project/scholarly/</a>) probably allows me to do the same. I wanted
to find out a bit more regarding http requests and its implications.</p>
<p>get_stats_serial.py is waiting until each task(load webpage of researcher X) is completed, and only after that proceeds with the new author (Y).
this simple approach comes with the expense of time complexity O(N), meaning as long as the amount of researcher is ‘little’ it won’t require too much time.</p>
<p>This problem has a bottleneck in the speed which is the network, crawling the web is time expensive and the amount of request accepted by servers is limited and has to be respected.</p>
<p>A method to avoid the system staying idle while the web server responds is to allow multple tasks to run simultaneously.</p>
<p>get_stats_coroutine.py wants to exploit this strategy.</p>
<p>A proper timing sleep function must be setted inside each file in order to avoid rejection by the server.
If we are requesting informations too fast, the server will answer always with an [Error 429 Too Many Requests].</p>
<p>The serial script has been tested to query at a speed of 0,7 researcher per second.
The coroutine script has been tested to query at a speed of 0.05 researcher per second.</p>
<h2>sutlxwhx/scholar-parser: This is a PHP example of how you can use Phantom.js to extract <abbr title="[object Object]">links</abbr> from the first page of Google Scholar SERP in one page web application.</h2>
<p><a href="https://github.com/sutlxwhx/scholar-parser">https://github.com/sutlxwhx/scholar-parser</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>Uses PhantomJS as headless browser.</li>
<li>Uses randomizing User-Agent strings to thwart Scholar police: “Randomize current user-agent for each request to avoid Google rate limiting” <a href="https://github.com/sutlxwhx/scholar-parser/blob/master/app/ua.php">https://github.com/sutlxwhx/scholar-parser/blob/master/app/ua.php</a></li>
<li>Has RECAPTCHA processing: “Receive recaptcha response for a current user. When I created this project I was not aware that there is official recaptcha PHP client library <a href="https://github.com/google/recaptcha">https://github.com/google/recaptcha</a>” <a href="https://github.com/sutlxwhx/scholar-parser/blob/master/app/functions.php">https://github.com/sutlxwhx/scholar-parser/blob/master/app/functions.php</a></li>
<li>Vanilla URL querying</li>
<li>PHP</li>
</ul>
<h2>xzk-seu/SpiderForGoogleScholar: 鱼塘</h2>
<p><a href="https://github.com/xzk-seu/SpiderForGoogleScholar">https://github.com/xzk-seu/SpiderForGoogleScholar</a></p>
<h2>madhawadias/google_scholar_scrapper: A scrapping tool to scrape article attributes from <a href="http://scholar.google.com">scholar.google.com</a></h2>
<p><a href="https://github.com/madhawadias/google_scholar_scrapper">https://github.com/madhawadias/google_scholar_scrapper</a></p>
<h2>LMBertholdo/google_scholar_crawler_coop</h2>
<p><a href="https://github.com/LMBertholdo/google_scholar_crawler_coop">https://github.com/LMBertholdo/google_scholar_crawler_coop</a></p>
<h2>aless80/Google-Scholar-scraper: Download information from Google Scholar for a number of author names</h2>
<p><a href="https://github.com/aless80/Google-Scholar-scraper">https://github.com/aless80/Google-Scholar-scraper</a></p>
<h2>LucasVadilho/nodeGoogleScholar</h2>
<p><a href="https://github.com/LucasVadilho/nodeGoogleScholar">https://github.com/LucasVadilho/nodeGoogleScholar</a></p>
<h2>jakeelkins/google-scholar-analysis: Some code I’m writing for analyzing research areas using google scholar, NLP, topic modeling, clustering, etc.</h2>
<p><a href="https://github.com/jakeelkins/google-scholar-analysis">https://github.com/jakeelkins/google-scholar-analysis</a></p>
<h2>sfhall/Google-Scholar-ID-Grabber: Python script that takes in an excel list and gets the Google Scholar ID for each name</h2>
<p><a href="https://github.com/sfhall/Google-Scholar-ID-Grabber">https://github.com/sfhall/Google-Scholar-ID-Grabber</a></p>
<h2>profmike/Google-Scholar-Stats: Parses author citation and h-index statistics from Google Scholar</h2>
<p><a href="https://github.com/profmike/Google-Scholar-Stats">https://github.com/profmike/Google-Scholar-Stats</a></p>
<h2>mogekag/sci-stat: Automated google scholar statistics crawler based on <a href="http://Scholar.py">Scholar.py</a></h2>
<p><a href="https://github.com/mogekag/sci-stat">https://github.com/mogekag/sci-stat</a></p>
<h2>hrlblab/ISN_KI_PubMed_GoogleScholar</h2>
<p><a href="https://github.com/hrlblab/ISN_KI_PubMed_GoogleScholar">https://github.com/hrlblab/ISN_KI_PubMed_GoogleScholar</a></p>
<h2>kylermurphy/scholar_plot: Simple Plot for google scholar</h2>
<p><a href="https://github.com/kylermurphy/scholar_plot">https://github.com/kylermurphy/scholar_plot</a></p>
<p>Simple Plot for google scholar and scopus information</p>
<p>Requires <a href="https://pybliometrics.readthedocs.io/en/stable/index.html">pybliometrics</a> for Scopus and <a href="https://github.com/OrganicIrradiation/scholarly">scholary</a> for Google Scholar.</p>
<p>pybliometrics was installed with pip, however it requires a license/network access and so publication numbers are hardcoded for now from <a href="https://www.scopus.com/freelookup/form/author.uri">Scopus Author seach</a></p>
<pre><code>pip install pybliometrics
</code></pre>
<p>scholary was installed via GitHub</p>
<pre><code>pip install -U git+https://github.com/OrganicIrradiation/scholarly.git
</code></pre>
<h2>couetilc/selenium-web-scraping: scraping google scholar using selenium</h2>
<p><a href="https://github.com/couetilc/selenium-web-scraping">https://github.com/couetilc/selenium-web-scraping</a></p>
<h3>Analysis Notes</h3>
<p>Selenium driver, obviously…</p>
<h2>crmne/googlescholarscraper: A scraper for Google Scholar, written in Python</h2>
<p><a href="https://github.com/crmne/googlescholarscraper">https://github.com/crmne/googlescholarscraper</a></p>
<p>GoogleScholarScraper is a <a href="https://scrapy.org/">Scrapy</a> project that implements a scraper for Google Scholar.</p>
<h2>Features</h2>
<ul>
<li>Extracts Authors, Title, Year, Journal, and Url.</li>
<li>Exports to CSV, JSON and BibTeX.</li>
<li>Cookie and referer support for higher query volumes.</li>
<li>Optimistically tries the next page in case of server errors.</li>
<li>Supports the full Google Scholar query syntax for authors, title, exclusions, inclusions, etc. Check out those <a href="http://www.otago.ac.nz/library/pdf/Google_Scholar_Tips.pdf">search tips</a>.</li>
</ul>
<h3>Analysis Notes</h3>
<p>Uses Scrapy, which I have yet to look into.</p>
<h2>callumparker/Google-Scholar-PDF-Link-Scraper: Scrape Google Scholar for PDF <abbr title="[object Object]">links</abbr> based on a keyword. Written in Python.</h2>
<p><a href="https://github.com/callumparker/Google-Scholar-PDF-Link-Scraper">https://github.com/callumparker/Google-Scholar-PDF-Link-Scraper</a></p>
<p>Scrape multiple Google Scholar pages for PDF <abbr title="[object Object]">links</abbr> based on a keyword(s).</p>
<ul>
<li>Automatically downloads PDF files to the directory of the script.</li>
<li>Creates a text file with PDF <abbr title="[object Object]">links</abbr>.</li>
</ul>
<h3>Analysis Notes</h3>
<p>Basic URL querying. Nothing fancy. Not even error handling.</p>
<h2>pradeepsen99/Google-Scholar-Web-App-DB: A web-app to visualize the different researchers on Google Scholar along with their relationships to other researchers.</h2>
<p><a href="https://github.com/pradeepsen99/Google-Scholar-Web-App-DB">https://github.com/pradeepsen99/Google-Scholar-Web-App-DB</a></p>
<h3>Analysis Notes</h3>
<p>Doesn’t seem to contain anything Google Scholar like.</p>
<p>Is a React website basic site AFAICT.</p>
<h2>ardirsaputra/Data-Mining-For-Google-Scholar: this repository used for educational purpose in the course data mining 2019 informatic engineer university of lampung</h2>
<p><a href="https://github.com/ardirsaputra/Data-Mining-For-Google-Scholar">https://github.com/ardirsaputra/Data-Mining-For-Google-Scholar</a></p>
<h3>Analysis Notes</h3>
<p>Looks like a website, <strong>without any scraper</strong>. There’s a ZIP file in the repo that <em>maybe</em> contains GS data, but I see no way this code is scraping GS, at least not in this initial quick scan. Nothing obvious or prominent, like <code>scholar.py</code> or <code>scholarly</code>. It’s PHP + JS code.</p>
<h2>janneliukkonen/google-scholar-results-counter-scraper: Small web scraper to quickly evaluate list of ML algorithms against whitepapers using Google Scholar.</h2>
<p><a href="https://github.com/janneliukkonen/google-scholar-results-counter-scraper">https://github.com/janneliukkonen/google-scholar-results-counter-scraper</a></p>
<h3>Analysis Notes</h3>
<p>basic scraper, nothing fancy. Uninteresting therefore.</p>
<h2>zhang-hz/zotero-autofetch: Zotero plugin for automatic download of PDFs from Scihub and Google Scholar</h2>
<p><a href="https://github.com/zhang-hz/zotero-autofetch">https://github.com/zhang-hz/zotero-autofetch</a></p>
<h3>Analysis Notes</h3>
<p>Since this looks like a FireFox addon (.xul files…) we <em>might</em> want to look into it a little further at some point: same idea we had for the Chrome extension but now for firefox, maybe?</p>
<h2>Manikaran20/Better_metrics_for_google_Scholars: This work is for all the scholars who have a google scholar profile, associated with the idea of providing a better and fairer results to them.</h2>
<p><a href="https://github.com/Manikaran20/Better_metrics_for_google_Scholars">https://github.com/Manikaran20/Better_metrics_for_google_Scholars</a></p>
<h3>Analysis Notes</h3>
<p>Selenium driver…</p>
<h2>goose0058/scholarbot: A small script to pull down references from google scholar.</h2>
<p><a href="https://github.com/goose0058/scholarbot">https://github.com/goose0058/scholarbot</a></p>
<h2>sarthak-patidar/scholar-crawler: A spider to crawl google scholar.</h2>
<p><a href="https://github.com/sarthak-patidar/scholar-crawler">https://github.com/sarthak-patidar/scholar-crawler</a></p>
<h3>Analysis Notes</h3>
<p>Hm. <s>Another Scrapy commercial Scraper API user!</s></p>
<h4><em>Update</em></h4>
<p>My bad! That’s <strong>not</strong> the commercial Scraper API, but <a href="https://scrapy.org/">Scrapy</a> i.e. <a href="https://scrapy.org/">https://scrapy.org/</a></p>
<p>Haven’t yet looked into that one to see what it does in terms of VPN hopping, UserAgent randomization, etc.</p>
<h2>theclementho/Scholar-Crawler: ECE496 Capstone - Crawler prototype for Google Scholar</h2>
<p><a href="https://github.com/theclementho/Scholar-Crawler">https://github.com/theclementho/Scholar-Crawler</a></p>
<h3>Analysis Notes</h3>
<p>Has its own copy of <code>scholarly</code> and runs on top of that one. To be inspected further at a later date.</p>
<h2>maze-runnar/my-scholarly: Use Scholarly to fetch google scholar data</h2>
<p><a href="https://github.com/maze-runnar/my-scholarly">https://github.com/maze-runnar/my-scholarly</a></p>
<p>Use Scholarly to fetch google scholar data</p>
<p>###Project description</p>
<p>scholarly is a module that allows you to retrieve author and publication information from Google Scholar in a friendly, Pythonic way.</p>
<h3>Usage</h3>
<p>Because scholarly does not use an official API, no key is required.</p>
<h3><strong>Stand on the shoulders of giants</strong></h3>
<p>Google Scholar provides a simple way to broadly search for scholarly literature. From one place, you can search across many disciplines and sources: articles, theses, books, abstracts and court opinions, from academic publishers, professional societies, online repositories, universities and other web sites. Google Scholar helps you find relevant work across the world of scholarly research.</p>
<h3>Analysis Notes</h3>
<p>Yada yada. See later if this adds any value on top of <code>scholarly</code>. It’s the grabbing that’s the hard part so I guess not, but I <em>could</em> be mistaken. (Yeah, I’m getting bitchy when the clock turns into the night and I’ve got a few more entries to go. Did that to myself, though, no-one else to blame…)</p>
<h2>akhilanto/GoogleScholar-WebScarping-Using-Free-VPN-in-Python: GoogleScholar Web Scraping using Free VPN In Python</h2>
<p><a href="https://github.com/akhilanto/GoogleScholar-WebScarping-Using-Free-VPN-in-Python">https://github.com/akhilanto/GoogleScholar-WebScarping-Using-Free-VPN-in-Python</a></p>
<h3>GoogleScholar-WebScraping-Using-VPN</h3>
<p>Since Google Scholar doesn’t provide any API  this Script can be used to Web scrap Google Scholar to get Citations and Authors for a Published paper. Here we are providing the papers from DBLP website. By using free VPN, this program overcomes the google captcha .The program works in the following way</p>
<ol>
<li>Importing Packages</li>
<li>Getting published papers from DBLP website for a provided link</li>
<li>Getting free VPN</li>
<li>Google Scholar web search  for the given paper</li>
<li>Scraping the Google Scholar</li>
<li>Converting the data into Data Frame and saving it as CSV output</li>
</ol>
<h3>Analysis Notes</h3>
<p>Now this sounds a lot like a basic <code>scholarly</code>. To be investigated further.</p>
<h2>jamespreed/scholar-crawler: Scrapes Google scholar to build a networks of co-authorship.</h2>
<p><a href="https://github.com/jamespreed/scholar-crawler">https://github.com/jamespreed/scholar-crawler</a></p>
<p>Because of captchas, this runs using selenium and Firefox, so you must have Firefox installed. This is currently designed for Windows, but the only Feel free to use the browser of your choice, you will need to roll your own session class.</p>
<h2>dgalaktionov/scholar.py: A parser for Google Scholar, written in Python</h2>
<p><a href="https://github.com/dgalaktionov/scholar.py">https://github.com/dgalaktionov/scholar.py</a></p>
<h3><a href="http://scholar.py">scholar.py</a></h3>
<p><strong>WARNING</strong>: This repository is a derived work from two different forks, from @machaerus and @jessamynsmith on the original repository in <a href="https://github.com/ckreibich/scholar.py">https://github.com/ckreibich/scholar.py</a>. This is the cleanest option I see for uploading the version I need, considering:</p>
<ul>
<li>The original project is obviously abandoned</li>
<li>Forking only one of the authors would be inaccurate</li>
<li><a href="https://www.niels-ole.com/ownership/2018/03/16/github-forks.html">Github can make you lose access on your forks</a>.</li>
</ul>
<p><code>scholar.py</code> is a Python module that implements a querier and parser for Google Scholar’s output. Its classes can be used independently, but it can also be invoked as a command-line tool.</p>
<p>The script used to live at <a href="http://icir.org/christian/scholar.html">http://icir.org/christian/scholar.html</a>, and I’ve moved it here so I can more easily manage the various patches and suggestions I’m receiving for <a href="http://scholar.py">scholar.py</a>. Thanks guys, for all your interest! If you’d like to get in touch, email me at <a href="mailto:christian@icir.org">christian@icir.org</a> or ping me <a href="http://twitter.com/ckreibich">on Twitter</a>.</p>
<p>Cheers,<br>
Christian</p>
<h3>Features</h3>
<ul>
<li>Extracts publication title, most relevant web link, PDF link, number of citations, number of online versions, link to Google Scholar’s article cluster for the work, Google Scholar’s cluster of all works referencing the publication, and excerpt of content.</li>
<li>Extracts total number of hits as reported by Scholar (new in version 2.5)</li>
<li>Supports the full range of advanced query options provided by Google Scholar, such as title-only search, publication date timeframes, and inclusion/exclusion of patents and citations.</li>
<li>Supports article cluster IDs, i.e., information relating to the variants of an article already identified by Google Scholar</li>
<li>Supports retrieval of citation details in standard external formats as provided by Google Scholar, including BibTeX and EndNote.</li>
<li>Command-line tool prints entries in CSV format, simple plain text, or in the citation export format.</li>
<li>Cookie support for higher query volume, including ability to persist cookies to disk across invocations.</li>
</ul>
<h3>Note</h3>
<p>I will always strive to add features that increase the power of this
API, but I will never add features that intentionally try to work
around the query limits imposed by Google Scholar. Please don’t ask me
to add such features.</p>
<h3>Analysis Notes</h3>
<p>Some folks can be too ethical. 😉 This is a <code>scholar.py</code> fork which isn’t listed as one. Have a look at what he did when the time comes.</p>
<h2>ukalwa/scholarly: A Node.js module to fetch and parse academic articles from google scholar</h2>
<p><a href="https://github.com/ukalwa/scholarly">https://github.com/ukalwa/scholarly</a></p>
<h3>Analysis Notes</h3>
<p>TypeScript module. Certainly DOES NOT have the features of <code>scholarly</code> (the Python module) as this one uses straight URL querying via cheeerio.</p>
<p>From the README:</p>
<p>A Node.js module to fetch and parse academic articles from Google Scholar.</p>
<h4>Acknowledgements</h4>
<p>This project was inspired from other awesome projects (<a href="https://github.com/ckreibich/scholar.py">scholar.py</a>, <a href="https://github.com/VT-CHCI/google-scholar">google-scholar</a>, and <a href="https://github.com/martinchapman/google-scholar-extended">google-scholar-extended</a>)</p>
<h2>Marcelobbr/web_crawler: Web crawler of Google Scholar profiles</h2>
<p><a href="https://github.com/Marcelobbr/web_crawler">https://github.com/Marcelobbr/web_crawler</a></p>
<p>For the web scraping to work with Google Chrome, you need to install chromedriver.</p>
<h3>Analysis Notes</h3>
<p>Ah well…</p>
<h2>lydianish/brag-gs: A Google Scholar API for BRAG</h2>
<p><a href="https://github.com/lydianish/brag-gs">https://github.com/lydianish/brag-gs</a></p>
<h3>Analysis Notes</h3>
<p>Uses <code>scholarly</code> to do the hard work…</p>
<h2>alexyashin/scholar-downloader: Chrome extension to download files from Google Scholar search result</h2>
<p><a href="https://github.com/alexyashin/scholar-downloader">https://github.com/alexyashin/scholar-downloader</a></p>
<h3>Analysis Notes</h3>
<p>Chrome extension. Code is 6 years old now. Still useful for PDF fetching? I don’t know. Not my first choice there.</p>
<h2>Rhaigtz/scholar-scraping: Creacion de funcion para scraping de google scholar.</h2>
<p><a href="https://github.com/Rhaigtz/scholar-scraping">https://github.com/Rhaigtz/scholar-scraping</a></p>
<h3>Analysis Notes</h3>
<p><a href="https://github.com/Rhaigtz/scholar-scraping/blob/master/src/utils/scholar.js">https://github.com/Rhaigtz/scholar-scraping/blob/master/src/utils/scholar.js</a> :
Rate limit detection, request rate limiting in an attempt to ccircumvent Google Scholar locking up. JavaScript code, looks clean to me.</p>
<h2>zouzhenhong98/scholartobib: a toot to grab bib info from google scholar, and write it to a bib file</h2>
<p><a href="https://github.com/zouzhenhong98/scholartobib">https://github.com/zouzhenhong98/scholartobib</a></p>
<h3>Analysis Notes</h3>
<p><a href="https://github.com/zouzhenhong98/scholartobib/blob/master/scholar.py">https://github.com/zouzhenhong98/scholartobib/blob/master/scholar.py</a> : randomized GoogleID for the query, SOCKS5 proxy (tor!), CAPTCHA detection, …</p>
<p>Comment from code: “Routes scholarly through a proxy (e.g. tor).        Requires pysocks.        Proxy must be running.”</p>
<p>It’s not <code>scholarly</code> but certainly using the same kind of mechanisms to thwart GS.</p>
<p>Interesting!</p>
<h2>Rosyuku/gssearch: google-scholar検索効率化</h2>
<p><a href="https://github.com/Rosyuku/gssearch">https://github.com/Rosyuku/gssearch</a></p>
<p>Search efficiency improvement</p>
<h3>Analysis Notes</h3>
<p>Looks a bit like an early(?) <code>scholarly</code>: UserAgent randomization is in there, but I don’t see proxy/VPN hopping, but that be me, my deteriorating eyes and the late hour. (Yup, been updating this document in reverse order as a stupid keyboard miss had me jump to the end of the tabs earlier and I didn’t want to screw up Chrome any more than I already had at that moment. Anyway, that’s nothing to bother you with so why am I writing this line?! :deep-thought:)</p>
<p>Here’s [the source code](<a href="https://github.com/Rosyuku/gssearch/blob/master/">https://github.com/Rosyuku/gssearch/blob/master/</a>&lt;google_scholar_search class=“py”&gt;&lt;/google_scholar_search&gt;)'s top comment:</p>
<blockquote>
<p>Created on Sun May 31 00:23:02 2020</p>
<p>@author: Wakasugi Kazuyuki</p>
<h3>Works Cited</h3>
<ul>
<li><a href="https://own-search-and-study.xyz/2019/06/09/python-scraping-icml2019-summary/">https://own-search-and-study.xyz/2019/06/09/python-scraping-icml2019-summary/</a></li>
<li><a href="https://serpapi.com/google-scholar-api">https://serpapi.com/google-scholar-api</a></li>
<li><a href="https://qiita.com/kuto/items/9730037c282da45c1d2b">https://qiita.com/kuto/items/9730037c282da45c1d2b</a></li>
<li><a href="https://github.com/scholarly-python-package/scholarly">https://github.com/scholarly-python-package/scholarly</a></li>
</ul>
</blockquote>
<h2>Neo-101/etudier-improved: Extract a citation network from Google Scholar</h2>
<p><a href="https://github.com/Neo-101/etudier-improved">https://github.com/Neo-101/etudier-improved</a></p>
<p><em>étudier</em> is a small Python program that uses [Selenium] and [requests-html] to
drive a <em>non-headless</em> browser to collect a citation graph around a particular
[Google Scholar] citation or set of search results. The resulting network is
written out as a [Gephi] file and a [D3] visualization using [networkx].
Current D3 visualization is inspired by [eyaler]. <em>The D3 visualization could
use some work, so if you add style to it please submit a pull request.</em></p>
<p>If you are wondering why it uses a non-headless browser it’s because Google is
[quite protective] of this data and routinely will ask you to solve a captcha
(identifying street signs, cars, etc in photos).  <em>étudier</em> will allow you to
complete these tasks when they occur and then will continue on its way
collecting data.</p>
<h3>Install</h3>
<p>You’ll need to install [ChromeDriver] before doing anything else. If you use
Homebrew on OS X this is as easy as:</p>
<pre><code>brew install chromedriver
</code></pre>
<p>Then you’ll want to install [Python 3] and:</p>
<pre><code>pip3 install etudier
</code></pre>
<h3>Run</h3>
<p>To use it you first need to navigate to a page on Google Scholar that you are
interested in, for example here is the page of citations that reference Sherry
Ortner’s [Theory in Anthropology since the Sixties]. Then you start <em>etudier</em> up
pointed at that page.</p>
<pre><code>% etudier 'https://scholar.google.com/scholar?start=0&amp;hl=en&amp;as_sdt=20000005&amp;sciodt=0,21&amp;cites=17950649785549691519&amp;scipsc='
</code></pre>
<p>If you are interested in starting with keyword search results in Google Scholar
you can do that too. For example here is the url for searching for “cscw memory”
if I was interested in papers that talk about the CSCW conference and memory:</p>
<pre><code>% etudier 'https://scholar.google.com/scholar?hl=en&amp;as_sdt=0%2C21&amp;q=cscw+memory&amp;btnG='
</code></pre>
<p>Note: it’s important to quote the URL so that the shell doesn’t interpret the
ampersands as an attempt to background the process.</p>
<h3>–pages</h3>
<p>By default <em>étudier</em> will collect the 10 citations on that page and then look at
the top 10 citatations that reference each one. So you will end up with no more
than 100 citations being collected (10 on each page * 10 citations).</p>
<p>If you would like to get more than one page of results use the <code>--pages</code>. For
example this would result in no more than 400 (20 * 20) results being collected:</p>
<pre><code>% etudier --pages 2 'https://scholar.google.com/scholar?start=0&amp;hl=en&amp;as_sdt=20000005&amp;sciodt=0,21&amp;cites=17950649785549691519&amp;scipsc=' 
</code></pre>
<h2>bsodhi/books_scraper: Books scraper for Google Scholar and Goodreads</h2>
<p><a href="https://github.com/bsodhi/books_scraper">https://github.com/bsodhi/books_scraper</a></p>
<h3>Prerequisites</h3>
<ol>
<li>Install Python for your operating. You can <a href="https://www.python.org/downloads/release/python-382/">download Python 3.8.2 from here</a>.</li>
<li>This program makes use of <a href="https://www.selenium.dev/documentation/en/webdriver/driver_requirements/">Selenium WebDriver</a>
for fetching GoodReads book shelf data. You should have a driver installed for your
browser. Currently supported browsers are: Chrome, Firefox, Edge and Safari. We have tested with Firefox and Safari (on macOSX 10.14.6).</li>
</ol>
<h2>coryjcombs/Scholar-search: Multi-page, multi-term scraper for Google Scholar results</h2>
<p><a href="https://github.com/coryjcombs/Scholar-search">https://github.com/coryjcombs/Scholar-search</a></p>
<h3>Scholar-Search</h3>
<p>A multi-page, multi-term scraper for Google Scholar results (version 1.0.6).</p>
<h3>Background</h3>
<p>This scraper was developed for use in a systematic review of scholarship on electricity generation, co-authored by Sarah M. Jordaan, Cory J. Combs, and Edeltraud Günther. The collected data served as the basis for an article being prepared for submission in early 2020.</p>
<h3>Details</h3>
<ul>
<li>Designed to scrape all results of Google Scholar searches, up to Scholar’s imposed maximum of 100 pages (1000 results) for each search.</li>
<li>Developed using BeautifulSoup, Pandas, and the requests and time packages.</li>
</ul>
<h3>Credits</h3>
<ul>
<li>This code builds upon a single-page scraper for <a href="http://Google.com">Google.com</a> search results developed by Edmund Martin, whose original work is <a href="https://edmundmartin.com/scraping-google-with-python/">available here</a>. Many thanks and all due credit to Edmund Martin!</li>
<li>Adaptation for Google Scholar, as well as iteration over pages, data extraction and manipulation, and export control were coded by Cory J. Combs.</li>
</ul>
<h3>Scraper Components</h3>
<ol>
<li>A user agent, which provides identifying information to the server</li>
<li>A function to fetch results</li>
<li>A function to parse results</li>
<li>An function to execute fetching and parsing with error handlers</li>
<li>The main search script, which:</li>
</ol>
<ul>
<li>executes the search with the input parameters,</li>
<li>outputs the results in a pandas data frame,</li>
<li>extracts metadata elements not consistently identifiable through Google Scholar’s html or xml alone,</li>
<li>cleans and formats the data, and</li>
<li>exports the fully formatted dataframe into Excel.</li>
</ul>
<p>The results may be explored in the output Excel file or in Python using pandas. The final formatted pandas data frame is called “data_df_clean” by default.</p>
<h3>Ethical Scraping</h3>
<p>Without appropriate constraints, web scraping can cause undue stress on a server. As such, special care was taken in implementing this scraper to ensure ethical use of server requests, first by scripting pauses between both page iterations and individual result collections, and second by separating execution of each search across the day, over multiple days, and avoiding peak usage times. When developing the script, a sample test was manually confirmed to yield a small number of results prior to execution to avoid unnecessary server burden.</p>
<p>For an interesting exploration of scraping Google Scholar results at a far larger scale, and through different means, see <a href="https://www.nature.com/articles/d41586-018-04190-5">Else 2018 in Nature</a>.</p>
<h3>Analysis Notes</h3>
<p>Right. Right. Anyway, this one uses UserAgent spoofing and nothing else, just plain website requesting.</p>
<p>Now for the referenced articles:</p>
<h4><a href="https://edmundmartin.com/scraping-google-with-python/">https://edmundmartin.com/scraping-google-with-python/</a></h4>
<p>That’s basically <code>scholar.py</code> so no magic what-so-ever.</p>
<h4><a href="https://www.nature.com/articles/d41586-018-04190-5">https://www.nature.com/articles/d41586-018-04190-5</a></h4>
<p>Quoting a bit here (<abbr title="[object Object]">emphasis</abbr> mine):</p>
<blockquote>
<h3>How did you get around the fact that Google Scholar has no API?</h3>
<p>We spent three months scraping data from the website. I created a script to do so, but I had to be there to keep manually solving the CAPTCHAs that appeared regularly.
It was a boring summer! We used several computers to distribute the enquiries because Google Scholar asks you to solve a CAPTCHA if one computer is making too many requests.
<strong>Sometimes the CAPTCHAs appear so frequently that it is not practical to get the data this way. We don’t think it is a reliable method of getting the data.</strong></p>
<h3>How many CAPTCHAs did you solve over the course of the experiment?</h3>
<p>I can’t tell you the exact number, but many hundreds!</p>
<h3>How long would it have taken to extract the data if an API was available from Google Scholar?</h3>
<p>One or two days.</p>
</blockquote>
<p>And there you have it: that’s basically what we’re fighting: it’s a tug of war with the Google engineers. Personally, I think <code>scholarly</code> is closest to a workable/usable scraper (there’s the “Scraper API” mentioned elsewhere in this doc, which turns out to be a commercial SaaS version of that one AFAICT from their blurbs. Maybe with some added Mechanical Turk if you buy the more expensive licenses of theirs, but otherwise just <code>scholarly</code> and that’s it. Note ny own findings / guestimates regarding VPN IP blocking: Google doesn’t need to maintain a blacklist manually there: all they have to do is monitor the incoming IP addresses and do a DNS reverse lookup to see if an IP address that’s frequenting their Scholar site belongs to a VPN company like NordVPN and then it’s down to counting requests and ‘downgrading’ those IP numbers when you encounter them. At least that’s what <em>I</em> would do if I were in their shoes: it’s fast, doesn’t need manual maintenance and all you have to do is be more strict enforcing your limits on these ‘suspect’ IP numbers. Since you have no published limits on Scholar anyway, you can get away with throttling the suspect ones and if someone complains the ball is in their court to proove that they are <strong>not</strong> using a VPN or proxy for their Scholar visits. Which leaves the rather more fluid(?) <code>tor</code> network… Which’ exit nodes can be detected too, I suppose. Hm. I wonder what FSF’s panopticon would say about the fingerprint of such a proxied visit: is it recognizable from a regular Chrome browser visit? I suppose so, as I seem to recall some older NSA/FBI work re ‘cracking’ darknet origins by monitoring tor exit nodes… Though I must say I don’t recall how that one was done back in the day – it’s been a few years.)</p>
<h2>edwardmfho/ScholarScrape: Google Scholar strangely does not has its own API. I use a rather stupid way to scrape the title and authors’ name from the scholar search query. Will expand the functionality of this repo in the future.</h2>
<p><a href="https://github.com/edwardmfho/ScholarScrape">https://github.com/edwardmfho/ScholarScrape</a></p>
<h3>Analysis Notes</h3>
<p>And another Selenium driver to kick off Chrome for browsing Google Scholar…</p>
<h2>aakashchandhoke/SpiderUnleashed: SpiderUnleashed is a webcrawler that retrieves the non-pdf results from educational websites because pdfs are easily available on Google Scholar. The application uses the inbuilt library of HTTrack that crawls the webpages of the provided topic to the application.</h2>
<p><a href="https://github.com/aakashchandhoke/SpiderUnleashed">https://github.com/aakashchandhoke/SpiderUnleashed</a></p>
<h3>Analysis Notes</h3>
<p>C# code. No magicks re Google Scholar quirks: <a href="https://github.com/aakashchandhoke/SpiderUnleashed/blob/master/LinksCrawler.cs">https://github.com/aakashchandhoke/SpiderUnleashed/blob/master/LinksCrawler.cs</a></p>
<p>The mention of HTTrack in that description has me wondering, but only for a bit.</p>
<h2>erenkarabacak/scholar_app: Simple Google Scholar Web Application (Created by using scholarly and Flask)</h2>
<p><a href="https://github.com/erenkarabacak/scholar_app">https://github.com/erenkarabacak/scholar_app</a></p>
<h2>glamrock/hypnoscholar: A twitterbot, whose primary function is to post Google Scholar <abbr title="[object Object]">links</abbr>.</h2>
<p><a href="https://github.com/glamrock/hypnoscholar">https://github.com/glamrock/hypnoscholar</a></p>
<h3>Analysis Notes</h3>
<p>Just a bit of <em>fun stuff</em>. Ruby code.</p>
<h2>maurice-schleussinger/SLR-Tools: Python scripts to perform a systematic literature review for Google Scholar and others</h2>
<p><a href="https://github.com/maurice-schleussinger/SLR-Tools">https://github.com/maurice-schleussinger/SLR-Tools</a></p>
<h3>Analysis Notes</h3>
<p>Uses rate limiting in an attempt to prevent robot detection to trigger, but no other magicks are performed it seems: <a href="https://github.com/maurice-schleussinger/SLR-Tools/blob/master/crawl_googlescholar.py">https://github.com/maurice-schleussinger/SLR-Tools/blob/master/crawl_googlescholar.py</a></p>
<p>Here’s the latest relevant commit message on that subject, 9 months ago: <a href="https://github.com/maurice-schleussinger/SLR-Tools/commit/23cad9975dd0f7547cba393c85709ff48f5cd84b">https://github.com/maurice-schleussinger/SLR-Tools/commit/23cad9975dd0f7547cba393c85709ff48f5cd84b</a></p>
<h2>Ze1598/Scrape-Academic-Social-Networks: Scrape information from Google Scholar, ResearchGate and <a href="http://Academia.edu">Academia.edu</a> with Python and Selenium</h2>
<p><a href="https://github.com/Ze1598/Scrape-Academic-Social-Networks">https://github.com/Ze1598/Scrape-Academic-Social-Networks</a></p>
<p>For a college project, me and a classmate had to find out how many documents the authors of each school from Instituto Politécnico do Porto (IPP) had published, along with some other metrics, in academic social networks, specifically Google Scholar, ResearchGate and <a href="http://Academia.edu">Academia.edu</a>. Unfortunately, there’s still no API support for none of them, and so I had to scrape this information with Python and Selenium.</p>
<p>These scripts are by no means API for the platforms, since they were tailored to our need, but I think these scripts offer a solid base for someone looking to start a project like that.</p>
<p>Due note that, because these scripts (Selenium) rely on a Google Chrome driver, you need to specify the path where it’s located. For my case, executing the driver once and having it in the same folder as the scripts was enough to run the script successfully afterwards.</p>
<p>The code will probably be a bit messy as I was more worried about getting the results than making the code readable and/or maintainable in the long run, but I feel it’s still clear enough as I wrote docstrings for every function and wrote comments for everything.</p>
<p>External sources:</p>
<ul>
<li>
<p>Selenium: <a href="https://www.seleniumhq.org/">https://www.seleniumhq.org/</a></p>
</li>
<li>
<p>Google Chrome’s driver download: <a href="https://chromedriver.storage.googleapis.com/index.html?path=73.0.3683.68/">https://chromedriver.storage.googleapis.com/index.html?path=73.0.3683.68/</a></p>
</li>
<li>
<p>Google Scholar: <a href="https://scholar.google.com/">https://scholar.google.com/</a></p>
</li>
<li>
<p>ResearchGate: <a href="https://www.researchgate.net/">https://www.researchgate.net/</a></p>
</li>
<li>
<p><a href="http://Academia.edu">Academia.edu</a>: <a href="https://www.academia.edu/">https://www.academia.edu/</a></p>
</li>
</ul>
<h2>murfel/pauper-scholar: 🎓A Chrome extension that allows to differentiate between free-access and paid-access articles in search results on Google Scholar.</h2>
<p><a href="https://github.com/murfel/pauper-scholar">https://github.com/murfel/pauper-scholar</a></p>
<h3>Pauper Scholar — Get it in [Chrome Web Store]</h3>
<p>Pauper Scholar is a Chrome extension for the Google Scholar website which adds an ability to differentiate between free-access and paid-access articles, in particular, it can hide all paid-access articles in search results.</p>
<p>An article is considered to be a free-access one if there’s a link to a paper next to it.</p>
<h3>Analysis Notes</h3>
<p><strong>Question</strong>: what’s keeping me from having that part of the Google Sniffer done as a Chrome extension instead? We can communicate across applications using websockets &amp; localhost, after all, so we could take the idea of the next repo (ag-gipp/recvis-tiny-scholar-api) along with this one and mix that into a Chrome extension which talks to Qiqqa…</p>
<h2>ag-gipp/recvis-tiny-scholar-api: This is for creating single purposed unofficial temporary Google Scholar API that will serve RecVis project.</h2>
<p><a href="https://github.com/ag-gipp/recvis-tiny-scholar-api">https://github.com/ag-gipp/recvis-tiny-scholar-api</a></p>
<p>This project is meant to be used as very small unofficial Google Scholar API for fetching bibliographic data based on input academic paper title. This API painfully slows down requests down to one request per 2 minute because Google Scholar is aggressively blocking the fetching process otherwise. Tiny Scholar API, whenever successfully fetching process happens, caches the request and doesn’t count it towards API fetching limit of one document per 2 minutes.</p>
<h3>Analysis Notes</h3>
<p>JavaScript code, which uses puppeteer, a headless browser. No special Google Scholar quirks circumvention sauce, apart from that slow rate of querying: one result per 2 minutes.</p>
<h2>aokabi/scholar-chrome-extension: Google Scholarの検索結果をリスト出力するChrome拡張</h2>
<p><a href="https://github.com/aokabi/scholar-chrome-extension">https://github.com/aokabi/scholar-chrome-extension</a></p>
<h3>Analysis Notes</h3>
<p>Alas, the tough bit is done by the browser. Nothing useful in this code. <a href="https://github.com/aokabi/scholar-chrome-extension/blob/master/src/content_scripts.js">https://github.com/aokabi/scholar-chrome-extension/blob/master/src/content_scripts.js</a></p>
<h2>driss14/googlescholarselenium: Simple script to download google scholar search to csv file using selenium web driver and beautiful soup</h2>
<p><a href="https://github.com/driss14/googlescholarselenium">https://github.com/driss14/googlescholarselenium</a></p>
<p>Simple supervised script to parse google scholar search to csv file using selenium web driver and beautiful soup.</p>
<h2>adbrucker/scholar-kpi: A tool for analysing publication related key performance indicates (KPIs) based on the information available at the Google Scholar page of an author.</h2>
<p><a href="https://github.com/adbrucker/scholar-kpi">https://github.com/adbrucker/scholar-kpi</a></p>
<h3>Analysis Notes</h3>
<p><a href="https://github.com/adbrucker/scholar-kpi/blob/master/src/LogicalHacking.ScholarKpi/Scraper/GoogleScholar.fs">Scrapes Google Scholar using F#</a> which is cool and everything, but there’s no error checking for the usual Google Scholar quirks AFAICT.</p>
<h2>bcmechen/find-pmid: Chrome extension that finds and displays PMID on Google Scholar</h2>
<p><a href="https://github.com/bcmechen/find-pmid">https://github.com/bcmechen/find-pmid</a></p>
<p>Find PMID is a Google Chrome extension that uses Entrez Programming Utilities (E-utilities) to find PMID (unique identifier used in PubMed), displays PMID, and provides one click access to the article page in PubMed for Google Scholar’s results.</p>
<h3>Analysis Notes</h3>
<p>Accessed the PubMed website: <a href="https://pubmed.ncbi.nlm.nih.gov/">https://pubmed.ncbi.nlm.nih.gov/</a></p>
<h2>lachrist/oghma: Oghma (responsibly) scrapes citation graphs from google-scholar</h2>
<p><a href="https://github.com/lachrist/oghma">https://github.com/lachrist/oghma</a></p>
<p>Oghma is a command-line tool for scraping a citation graph from <a href="https://scholar.google.com/">google-scholar</a> starting from some seminal works.
<a href="https://scholar.google.com/">google-scholar</a> will prompt a captcha from time to time even though Oghma uses Selenium and only launches requests every 5 to 10 seconds.
In which case a notification will pop-up; once you resolved the capcha, you can press <code>&lt;enter&gt;</code> in the terminal to resume the scraping.
Using a Firefox profile can help to remain undercover; being logged in a <a href="https://mail.google.com">gmail</a> account in this profile is even better.</p>
<h2>jessebrennan/citation_scraper: Pulls and formats citations for authors from Google Scholar</h2>
<p><a href="https://github.com/jessebrennan/citation_scraper">https://github.com/jessebrennan/citation_scraper</a></p>
<h3>Intro</h3>
<p>This is software used to scrape Google Scholar for citations by a
particular author. It makes use of ckreibich’s <a href="https://pybliometrics.readthedocs.io/en/stable/index.html">scholar.py</a>, with
a couple of <a href="https://github.com/OrganicIrradiation/scholarly">modifications</a>.</p>
<h3>Features</h3>
<h4>Caching</h4>
<p>Google blocking the program mid-run used to be a show stopper. All
of the citations already scraped would be lost and the program would
crash. Until… <strong>CACHING!</strong></p>
<p>Every time all of the citations for a particular author are scraped
they are added to a cache file called <code>.pickle_cache.dat</code> which is
created in the directory where the program is run. If the program
crashes due to a KeyboardInterrupt (^C) or from a 503 from Google’s
servers, the progress so far is saved to this file so that on the next
run the scraping can resume from where it left off.</p>
<h4>Refined Search</h4>
<p>Sometimes you want to limit your search only to authors that are part
of a particular institute or university. By using the <code>--words</code> option
one can specify that so that it’s reflected in the results. For example
<code>--words &quot;UC Santa Cruz Genomics Institute&quot;</code> will give only results
from authors within that institute.</p>
<h4>Waiting</h4>
<p>the <code>--wait</code> option can be used to wait for a specified number of
seconds between each query with the hopes that this won’t upset Google.
The effectiveness of this solution has not been verified.</p>
<h3>Trouble shooting</h3>
<p>Probably the only problem you will encounter is getting blocked by
Google Scholar’s API. There is a workaround!</p>
<p>You need:</p>
<ol>
<li>
<p>Mozilla Firefox</p>
</li>
<li>
<p>A Firefox extension that allows you to export cookies in the
Netscape cookie file format such as <a href="https://addons.mozilla.org/en-US/firefox/addon/cookie-exporter/">Cookie Exporter</a>.</p>
</li>
</ol>
<p>Then:</p>
<ol start="3">
<li>
<p>Navigate to one of the URLs that failed when requested (using
Firefox)</p>
</li>
<li>
<p>Fill out the captcha</p>
</li>
<li>
<p>Export the cookies from the page (as <code>cookies.txt</code>)</p>
</li>
<li>
<p>Save the file and run again but specify the <code>-c</code> option. For example</p>
<pre class="language-bash"><code class="language-bash">$ python3 citation_scraper zeppelin.txt output.txt -c cookies.txt
</code></pre>
</li>
</ol>
<h2>jjwallman/gscholartex: Parse saved Google Scholar webpage to extract citation data</h2>
<p><a href="https://github.com/jjwallman/gscholartex">https://github.com/jjwallman/gscholartex</a></p>
<p>The Google Scholar API is a little difficult and blocks repeated requests. I have not been able to find a way to load a profile with a specific number of citations showing, hence the manual steps.</p>
<h2>ShuDiamonds/twitterbot_googlescholar: the app aim is to send the infomation which is the result of thesis title analysis from google scholar</h2>
<p><a href="https://github.com/ShuDiamonds/twitterbot_googlescholar">https://github.com/ShuDiamonds/twitterbot_googlescholar</a></p>
<h3>Analysis Notes</h3>
<p>Looks rather unfinished or uses external services? <a href="https://github.com/ShuDiamonds/twitterbot_googlescholar/blob/master/posttweet.py">https://github.com/ShuDiamonds/twitterbot_googlescholar/blob/master/posttweet.py</a></p>
<h2>lalit3370/scrapy-googlescholar: Scraping google scholar for user page and citations page using scrapy and creating an API with scrapyrt</h2>
<p><a href="https://github.com/lalit3370/scrapy-googlescholar">https://github.com/lalit3370/scrapy-googlescholar</a></p>
<h3>Analysis Notes</h3>
<p>Huh? README says:</p>
<blockquote>
<ol start="13">
<li>Create a Scraper API account if you don’t want to get banned from google</li>
<li>Copy your API key and paste it in topl_project/topl_project/spiders/1.py lines 22 and 52</li>
</ol>
</blockquote>
<p>Now I wonder what that Scraper API is… A-ha!</p>
<p><a href="https://www.scraperapi.com/">https://www.scraperapi.com/</a></p>
<p>Proxy API for Web Scraping</p>
<p>Scraper API handles proxies, browsers, and CAPTCHAs, so you can get the HTML from any web page with a simple API call!</p>
<p><a href="https://www.scraperapi.com/pricing">https://www.scraperapi.com/pricing</a></p>
<p>One of the most frustrating parts of automated web scraping is constantly dealing with IP blocks and CAPTCHAs. Scraper API rotates IP addresses with each request, from a pool of millions of proxies across over a dozen ISPs, and automatically retries failed requests, so you will never be blocked. Scraper API also handles CAPTCHAs for you, so you can concentrate on turning websites into actionable data.</p>
<hr>
<p>So that looks like a commercial <a href="http://scholarly.py">scholarly.py</a> SaaS. 🤔</p>
<p>Meanwhile, there’s a API key apparently in an older commit, as there’s this commit: <a href="https://github.com/lalit3370/scrapy-googlescholar/commit/0b332967a35e9132073ee0f7fb18dcd57947f2c9">https://github.com/lalit3370/scrapy-googlescholar/commit/0b332967a35e9132073ee0f7fb18dcd57947f2c9</a>
which impacts <a href="https://github.com/lalit3370/scrapy-googlescholar/blob/master/topl_project/topl_project/spiders/1.py">https://github.com/lalit3370/scrapy-googlescholar/blob/master/topl_project/topl_project/spiders/1.py</a></p>
<h2>aptaheri/covid_response: Python scripts to extract text from Google Scholar docs</h2>
<p><a href="https://github.com/aptaheri/covid_response">https://github.com/aptaheri/covid_response</a></p>
<h2>philnova/citationscraper: Short script to pull well-formatted citations from Google scholar</h2>
<p><a href="https://github.com/philnova/citationscraper">https://github.com/philnova/citationscraper</a></p>
<p>Uses selenium to scrape formatted citations from Google Scholar.</p>
<p>We need to control a real browser instance, rather than just making HTTP requests,
because the actual citation is hidden behind a modal window. To get it, we need
to interact with JavaScript on the Scholar page, so we need a zombie browser.</p>
<p>N.B. Google Scholar won’t be happy about being scraped. Repeated use of this script
may lead to you being temporarily locked out.</p>
<h2>brinsonaml/PaperCrawler: Use Google scholar to search for papers and crawl content</h2>
<p><a href="https://github.com/brinsonaml/PaperCrawler">https://github.com/brinsonaml/PaperCrawler</a></p>
<h3>Analysis Notes</h3>
<p>Carries a copy (edited?) of <a href="http://scholar.py">scholar.py</a></p>
<p>Has code (<code>crawler.py</code>) which scrapes publications.
Journals include:</p>
<ul>
<li>IEEE proceedings</li>
<li>Elsevier: Composite science and technology</li>
<li>ACS</li>
</ul>
<h2>machetazo/sme: script de python que analiza resultados de google scholar</h2>
<p><a href="https://github.com/machetazo/sme">https://github.com/machetazo/sme</a></p>
<h3>Analysis Notes</h3>
<p>scraper uses <code>scholarly</code>: <a href="https://github.com/machetazo/sme/blob/master/sme/scraper.py#L3">https://github.com/machetazo/sme/blob/master/sme/scraper.py#L3</a></p>
<p>Translation: “we use these headers so that google believes we are firefox” at <a href="https://github.com/machetazo/sme/blob/master/sme/scraper.py#L20">https://github.com/machetazo/sme/blob/master/sme/scraper.py#L20</a>
so I guess they’re not doing UserAgent randomization here?</p>
<h1>Microsoft Academic Search</h1>
<h2>MicrosoftDocs/microsoft-academic-services</h2>
<p><a href="https://github.com/MicrosoftDocs/microsoft-academic-services">https://github.com/MicrosoftDocs/microsoft-academic-services</a></p>
<h2>Azure-Samples/academic-knowledge-analytics-visualization: Various examples to perform big data analytics over Microsoft Academic Graph and visualize the results.</h2>
<p><a href="https://github.com/Azure-Samples/academic-knowledge-analytics-visualization">https://github.com/Azure-Samples/academic-knowledge-analytics-visualization</a></p>
<h2>milindhg/Microsoft-Academic-Graph</h2>
<p><a href="https://github.com/milindhg/Microsoft-Academic-Graph">https://github.com/milindhg/Microsoft-Academic-Graph</a></p>
<h2>Azure-Samples/microsoft-academic-graph-pyspark-samples: Sample PySpark code for interacting with the Microsoft Academic Graph</h2>
<p><a href="https://github.com/Azure-Samples/microsoft-academic-graph-pyspark-samples">https://github.com/Azure-Samples/microsoft-academic-graph-pyspark-samples</a></p>
<h2>microsoft/mag-covid19-research-examples: Examples or utilizing Microsoft Academic for conducting covid-19 research</h2>
<p><a href="https://github.com/microsoft/mag-covid19-research-examples">https://github.com/microsoft/mag-covid19-research-examples</a></p>
<h3>Official Microsoft Sample</h3>
<!-- 
Guidelines on README format: https://review.docs.microsoft.com/help/onboard/admin/samples/concepts/readme-template?branch=master

Guidance on onboarding samples to docs.microsoft.com/samples: https://review.docs.microsoft.com/help/onboard/admin/samples/process/onboarding?branch=master

Taxonomies for products and languages: https://review.docs.microsoft.com/new-hope/information-architecture/metadata/taxonomies?branch=master
-->
<p>The code samples provided here provide WHO / PubMed ID -&gt; MAG ID mapping data as well
as code examples showing how to perform COVID-19 related analysis against the
<a href="https://www.microsoft.com/en-us/research/project/microsoft-academic-graph/">MAG</a> Dataset
and <a href="https://www.microsoft.com/en-us/research/project/academic-knowledge/">Project Academic Knowledge API</a>
or <a href="https://docs.microsoft.com/en-us/academic-services/knowledge-exploration-service/">MAKES API</a>.</p>
<h2>ropensci/microdemic: microsoft academic client</h2>
<p><a href="https://github.com/ropensci/microdemic">https://github.com/ropensci/microdemic</a></p>
<h2>microsoft/academic-knowledge-exploration-services-utilities: Utility tools and scripts for interacting with Microsoft Academic Knowledge Exploration Service (MAKES)</h2>
<p><a href="https://github.com/microsoft/academic-knowledge-exploration-services-utilities">https://github.com/microsoft/academic-knowledge-exploration-services-utilities</a></p>
<h2>jimbobbennett/MicrosoftAcademicContent: This repository lists content suitable for students/faculty to learn Azure and other Microsoft technologies</h2>
<p><a href="https://github.com/jimbobbennett/MicrosoftAcademicContent">https://github.com/jimbobbennett/MicrosoftAcademicContent</a></p>
<h2>subhash-pujari/MicrosoftAcademicSearchCrawler: This is the crawler for querying the microsoft academic search APIs in BFS(breadth first search way starting from the root node). We get a JSON response which is parsed and saved to the database.</h2>
<p><a href="https://github.com/subhash-pujari/MicrosoftAcademicSearchCrawler">https://github.com/subhash-pujari/MicrosoftAcademicSearchCrawler</a></p>
<h2>andreas-wilm/awesome-academic-graph: Awesome list for Microsoft Academic Graph</h2>
<p><a href="https://github.com/andreas-wilm/awesome-academic-graph">https://github.com/andreas-wilm/awesome-academic-graph</a></p>
<p>Awesome list for Microsoft Academic Graph (MAG)</p>
<h3>About MAG: comparisons, coverage etc.</h3>
<ul>
<li><a href="https://link.springer.com/article/10.1007%2Fs11192-019-03114-y">Two new kids on the block: How do Crossref and Dimensions compare with Google Scholar, Microsoft
Academic, Scopus and the Web of Science? (May, 2019)</a></li>
<li><a href="https://www.microsoft.com/en-us/research/project/academic/articles/cost-of-tracking-research-trends-and-impacts-with-microsoft-academic-graph/">Cost of tracking research trends and impacts with Microsoft Academic Graph (Feb 2019)</a></li>
<li><a href="https://harzing.com/blog/2017/11/publish-or-perish-version-6">Publish or Perish version 6 (Nov 2017)</a></li>
<li><a href="https://arxiv.org/ftp/arxiv/papers/1711/1711.08767.pdf">Microsoft Academic: A multidisciplinary comparison of citation counts with Scopus and Mendeley for 29 journals (Nov, 2017)</a></li>
<li><a href="https://arxiv.org/ftp/arxiv/papers/1703/1703.05539.pdf">The coverage of Microsoft Academic: Analyzing the publication output of auniversity (Sep 2017)</a></li>
<li><a href="http://www.dlib.org/dlib/september16/herrmannova/09herrmannova.html">An Analysis of the Microsoft Academic Graph (Sept 2016)</a></li>
<li><a href="http://cm.cecs.anu.edu.au/post/citation_analysis/">Eight Years of WSDM: Increasing Influence and Diversifying Heritage (Feb 2016)</a></li>
</ul>
<!-- - [Comparison of Microsoft Academic (Graph) with Web of Science, Scopus and Google Scholar](https://eprints.soton.ac.uk/408647/1/microsoft_academic_msc.pdf) -->
<ul>
<li><a href="https://www.frontiersin.org/articles/10.3389/fdata.2019.00045/full">A Review of Microsoft Academic Services for Science of Science Studies (Dec 2019)</a></li>
<li><a href="https://www.cwts.nl/blog?article=n-r2x284">CWTS: Mapping science using Microsoft Academic data</a></li>
</ul>
<h3>Analyses using MAG</h3>
<ul>
<li><a href="https://github.com/Azure-Samples/academic-knowledge-analytics-visualization">Analytics &amp; Visualization Samples for Academic Graph</a></li>
<li><a href="https://medium.com/ai2-blog/china-to-overtake-us-in-ai-research-8b6b1fe30595">China to Overtake US in AI Research (March, 2019)</a></li>
<li><a href="https://mdxminds.com/2016/11/17/microsoft-academic-is-the-phoenix-getting-wings/">Microsoft Academic: Is the Phoenix getting wings? (Nov 2017)</a></li>
<li><a href="https://arxiv.org/pdf/1704.05150.pdf">A Century of Science: Globalization of Scientific Collaborations,Citations, and Innovationsi (Aug, 2017)</a></li>
<li><a href="https://www.ncbi.nlm.nih.gov/pmc/articles/PMC5023123/">PR-Index: Using the h-Index and PageRank for Determining True Impact (Sept, 2016)</a></li>
<li><a href="http://cm.cecs.anu.edu.au/post/citation_vis/">Visualizing Citation Patterns of Computer Science Conferences (Aug, 2016)</a></li>
<li><a href="https://dl.acm.org/citation.cfm?doid=2872518.2890525">Investigations on Rating Computer Sciences Conferences: An Experiment with the Microsoft Academic Graph Dataset (Apr, 2016)</a></li>
<li><a href="https://dl.acm.org/citation.cfm?doid=2835776.2855119">WSDM Cup 2016: Entity Ranking Challengei (Feb, 2016)</a></li>
<li><a href="http://www.www2015.it/documents/proceedings/companion/p243.pdf">An Overview of Microsoft Academic Service (MAS) and Applications (May, 2015)</a></li>
<li><a href="http://abhie19.github.io/MS_Academic_Graph/">Citation recommendation of 80 Million papers using Graph DB(Neo-4J)</a></li>
</ul>
<h2>lquan/MicrosoftAcademicSearch: review of Microsoft Academic Search</h2>
<p><a href="https://github.com/lquan/MicrosoftAcademicSearch">https://github.com/lquan/MicrosoftAcademicSearch</a></p>
<h2>DanielDugan/MicrosoftAcademicPython</h2>
<p><a href="https://github.com/DanielDugan/MicrosoftAcademicPython">https://github.com/DanielDugan/MicrosoftAcademicPython</a></p>
<h2>mcialini/MicrosoftAcademicSearch: Determine duplicate authors from Microsoft’s massive research database</h2>
<p><a href="https://github.com/mcialini/MicrosoftAcademicSearch">https://github.com/mcialini/MicrosoftAcademicSearch</a></p>
<p>The Microsoft Academic Search is a research database which covers more than 50 million publications and over 19 million authors across a variety of domains. One of the main challenges with providing this service is caused by author-name ambiguity. There are many authors in the database which have unique IDs, but are the same author in reality. Given several csv files (most importantly Author.csv and PaperAuthor.csv), the task of this project is to determine which authors are duplicates.</p>
<p>The data mining algorithm I used in this project was extensive, and involved searching for a series of name variations of each author to see if perhaps they were listed under a nickname, or their name was misspelled. For example, one of the heuristics was to check all possible <abbr title="[object Object]">abbreviations</abbr> of a person’s name and see if that was listed under a different ID. So for John Doe Smith, the code would search for John D Smith, J Doe Smith, J D Smith, and J Smith.</p>
<p>After applying several of these heuristics, I received a 97.816% accuracy rating.</p>
<h3>Analysis Notes</h3>
<p>Code is 7 years old. Paper (PDF) is included with the Python code.</p>
<h2>coco11563/MicrosoftAcademicGraphDataMerge</h2>
<p><a href="https://github.com/coco11563/MicrosoftAcademicGraphDataMerge">https://github.com/coco11563/MicrosoftAcademicGraphDataMerge</a></p>
<h2>RapidSoftwareSolutions/Marketplace-MicrosoftAcademicSearch-Package: Discover more of what you need more quickly. Semantic search provides you with highly relevant search results from continually refreshed and extensive academic content from over 120 million publications.</h2>
<p><a href="https://github.com/RapidSoftwareSolutions/Marketplace-MicrosoftAcademicSearch-Package">https://github.com/RapidSoftwareSolutions/Marketplace-MicrosoftAcademicSearch-Package</a></p>
<h3>MicrosoftAcademicSearch Package</h3>
<p>Discover more of what you need more quickly. Semantic search provides you with   highly relevant search results from continually refreshed and extensive academic content from over 120 million publications.</p>
<ul>
<li>Domain: <a href="http://academic.research.microsoft.com/">academic.research</a></li>
<li>Credentials: key</li>
</ul>
<h3>How to get credentials:</h3>
<ol>
<li>Subscribe to the Microsoft Text Analytics API on the <a href="https://azure.microsoft.com/en-us/services/cognitive-services/">Microsoft Azure portal</a>.</li>
<li>Click create button.</li>
<li>In settings-&gt;credential section you will see apiKey (Ocp-Apim-Subscription-Key)</li>
</ol>
<h3>Analysis Notes</h3>
<p>Haven’t scanned the source code (PHP), but might be useful.</p>
<h2>DarrinEide/microsoft-academic: Documentation for all Microsoft Academic projects</h2>
<p><a href="https://github.com/DarrinEide/microsoft-academic">https://github.com/DarrinEide/microsoft-academic</a></p>
<h2>arnabsinha83/AcademicBot: Playing with Microsoft Academic API</h2>
<p><a href="https://github.com/arnabsinha83/AcademicBot">https://github.com/arnabsinha83/AcademicBot</a></p>
<h2>vwoloszyn/mag2elasticsearch: Migrating more than 160GiB of research data from Microsoft Academic Graph into an Analytics engine - Elasticsearch!</h2>
<p><a href="https://github.com/vwoloszyn/mag2elasticsearch">https://github.com/vwoloszyn/mag2elasticsearch</a></p>
<h3>Using Elasticsearch on Microsoft Academic Graph MAG</h3>
<p>Exploring more than 160 GiB of publications from Microsoft Academic Graph (MAG) using Elasticsearch!</p>
<h3>Download Microsoft Academic Graph</h3>
<p><a href="https://docs.microsoft.com/en-us/academic-services/graph/reference-data-schema">https://docs.microsoft.com/en-us/academic-services/graph/reference-data-schema</a></p>
<p><a href="https://zenodo.org/record/2628216">https://zenodo.org/record/2628216</a></p>
<pre><code>     4564007 Affiliations.txt
 16528778635 Authors.txt
     2224843 ConferenceInstances.txt
      428103 ConferenceSeries.txt
    55188690 FieldsOfStudy.txt
     5689662 Journals.txt
 40976541540 PaperAuthorAffiliations.txt
 32446006785 PaperReferences.txt
     7763592 PaperResources.txt
 60213784152 Papers.txt
 23096534376 PaperUrls.txt
 ----------------------------------------
173337504385 (~161.4) GiB
</code></pre>
<h2>hugoTO/Microsoft-Academic-Graph: Microsoft Academic Graph Guide</h2>
<p><a href="https://github.com/hugoTO/Microsoft-Academic-Graph">https://github.com/hugoTO/Microsoft-Academic-Graph</a></p>
<p>The Microsoft Academic Graph (MAG) is a heterogeneous graph containing scientific publication records, citation relationships between those publications, as well as authors, institutions, journals, conferences, and fields of study. This graph is used to power experiences in Bing, Cortana, Word, and in Microsoft Academic. The graph is currently being updated on a weekly basis.</p>
<p>In this tutorial, you are able to create a organization insights with MAG and PowerBI like this.</p>
<h2>ankeshanand/Microsoft-academic-crawler: Scripts to crawl the Microsoft academic site to create a database of research papers for building a citation network, written primarily in PHP.</h2>
<p><a href="https://github.com/ankeshanand/Microsoft-academic-crawler">https://github.com/ankeshanand/Microsoft-academic-crawler</a></p>
<h3>Analysis Notes</h3>
<p>7 years old, hence very probably obsolete.</p>
<h2>mattmarx/reliance_on_science: linkages from non-patent literature (NPL) references from USPTO patents since 1947 to academic papers since 1800 using Microsoft Academic Graph</h2>
<p><a href="https://github.com/mattmarx/reliance_on_science">https://github.com/mattmarx/reliance_on_science</a></p>
<p>The codes necessary to replicate Marx/Fuegi 2019 are contained in this directory. This code operates on, and assumes the presence of, a set of files from the Microsoft Academic Graph (MAG) and USPTO non-patent literature (NPL) references, described below.</p>
<h3>DISCLAIMERS</h3>
<p>The code is unsupported and is largely undocumented. It is provided primarily for those interested in understanding how the NPL linkages to MAG were accomplished. Moreover, it is executable only in a Sun Grid Engine (or similar) Unix environment with STATA installed as well as several packages including ftools and gtools and the Perl module Text::LevenshteinXS. It assumes the directory structure described below and contains hardcoded, fully-qualified pathnames. Moreover, you will need at least 5 terabytes of disk space, perhaps as much as 10.</p>
<p>There are four general steps in executing the matches: First, preparing the MAG data. Second, preparing the NPL data. Third, generating a first-pass set of “loose” matches. Fourth, scoring those “loose” matches and picking the best match for each NPL. Each of these major steps includes a number of sub-steps; there is no “master” script to run the process from beginning to end.</p>
<h2>lhviet/microsoft-academic-crawler: Crawling Title and Abstract information of papers from Microsoft Academic</h2>
<p><a href="https://github.com/lhviet/microsoft-academic-crawler">https://github.com/lhviet/microsoft-academic-crawler</a></p>
<h2>tczpl/BOP2016-Microsoft-Academic-Knowledge-API: Nodejs/ Microsoft Academic Knowledge API</h2>
<p><a href="https://github.com/tczpl/BOP2016-Microsoft-Academic-Knowledge-API">https://github.com/tczpl/BOP2016-Microsoft-Academic-Knowledge-API</a></p>
<p>Microsoft Beauty of Programming 2016 semi-final project</p>
<p>Use the given Microsoft Academic Search API to write a Restful API that returns all paths where the distance between two points (authors or papers) is &lt;4.</p>
<p>Because the ranking is based on response time, NodeJS asynchronous single thread is used.
After discussing ideas with teammates, I wrote the code. At the top, I was ranked in the 30s. However, I didn’t make the promotion.</p>
<h2>bethgelab/magapi-wrapper: Wrapper around Microsoft Academic Knowledge API to retrieve MAG data</h2>
<p><a href="https://github.com/bethgelab/magapi-wrapper">https://github.com/bethgelab/magapi-wrapper</a></p>
<p>Microsoft Academic knowledge provides rich API’s to retrieve information from Microsoft Academic Graph. MAG knowledge base is web-based heterogeneous entity graph which consists of entities such as Papers, Field of study, Authors, Affiliations, Citation Contexts, References etc.</p>
<p>This tool provides a wrapper around the Knowledge API to retrieve Authors, Field of Study and Papers data.</p>
<h2>Azure-Samples/microsoft-academic-knowledge-exploration-service-javascript-samples: Sample Javascript code for interacting with Microsoft Academic Knowledge Exploration Service (MAKES)</h2>
<p><a href="https://github.com/Azure-Samples/microsoft-academic-knowledge-exploration-service-javascript-samples">https://github.com/Azure-Samples/microsoft-academic-knowledge-exploration-service-javascript-samples</a></p>
<p>This sample creates a very simple webpage that leverages MAKES entity and semantic interpretation engines via javascript for searching academic papers.</p>
<h3>Microsoft Academic Knowledge Exploration Service (MAKES) Samples</h3>
<h4><a href="samples/academic-semantic-search-website/get-started.md">Academic semantic search website</a></h4>
<p>This sample creates a very simple webpage that leverages MAKES entity and semantic interpretation engines via javascript for searching academic papers.</p>
<h2>maysam/atn1</h2>
<p><a href="https://github.com/maysam/atn1">https://github.com/maysam/atn1</a></p>
<h3>Analysis Notes</h3>
<p>C# code</p>
<p>Has Microsoft Academic Search support, but I don’t see Google Scholar in there. (Done a very cursory source scan though.)</p>
<h2>supersambo/Author-Search-Msft-Academic-Search: A simple script to get publications of given authors from Microsoft Academic Search</h2>
<p><a href="https://github.com/supersambo/Author-Search-Msft-Academic-Search">https://github.com/supersambo/Author-Search-Msft-Academic-Search</a></p>
<h3>Publication search</h3>
<p>This is a very simple single purpose script to query the Microsoft Academic Search Api for publications based on a list of given author names.</p>
<p>In order to use this:</p>
<ul>
<li>Download this repository</li>
<li>Get an Api key from <a href="https://www.microsoft.com/cognitive-services/en-US/sign-up?ReturnUrl=/cognitive-services/en-us/subscriptions">here</a></li>
<li>Edit access_key.edit by filling in your own key and change the filename to access_key</li>
<li>Create a text file containing a list of authors (one per line) you want to query. Take <code>test.txt</code> as a reference if needed.</li>
<li>Run the script with the path to your input file as a command line argument e.g. like this
<code>python query_authors.py test.txt</code></li>
<li>The script will save the raw results as a single json file for each author to the <code>output/</code> directory</li>
</ul>
<hr>
<p>Note that this is everything but sophisticated and does not handle api errors.</p>
<p>If you run into API limits just stop the script and/or implement your own error handling. At least the console will tell you that there is something going wrong.</p>
<h2>wallyliu/PACInterview: Crawler of Microsoft Academic and Google Scholar implemented with python</h2>
<p><a href="https://github.com/wallyliu/PACInterview">https://github.com/wallyliu/PACInterview</a></p>
<h3>Analysis Notes</h3>
<p>From the README:</p>
<ol start="3">
<li>Google Scholar Crawler</li>
</ol>
<p>Use python to build a crawler for the following website</p>
<p>** (NOTE): This function cannot crawl target page because it will be detected as ROBOT. It only implements a parser part. **</p>
<hr>
<p>On the other hand, the code seems to include a recent Microsoft Academic Crawler but this code uses a Selenium driver to open a browser to access the site: <a href="https://github.com/wallyliu/PACInterview/blob/master/MSSpider.py#L2">https://github.com/wallyliu/PACInterview/blob/master/MSSpider.py#L2</a></p>
<h2>cfranck9/extract_article_abstract: Extract abstract of a journal article using Microsoft Academic API</h2>
<p><a href="https://github.com/cfranck9/extract_article_abstract">https://github.com/cfranck9/extract_article_abstract</a></p>
<p>A simplistic Python code to extract abstract of a single journal article using Microsoft Academic API. User can enter either title or DOI of a paper for MS database query (provide at least one of the two). DOI is converted to title through Crossref API.</p>
<h3>Analysis Notes</h3>
<p>Uses Chrome Driver to open up a browser.</p>
<h2>tranhungnghiep/CitationAnalysis: Citation Analysis on the Microsoft Academic Graph Dataset</h2>
<p><a href="https://github.com/tranhungnghiep/CitationAnalysis">https://github.com/tranhungnghiep/CitationAnalysis</a></p>
<p>Citation Analysis on the Microsoft Academic Graph Dataset</p>
<p>This contains some old code fragments for the citation analysis experiments in the past. The results were not reported formally but these codes are open sourced in case someone may find them useful. Note that the codes are old and some practices may have become outdated.</p>
<p>The codes concern the analysis and prediction of citation count of papers in a scholarly dataset, and may demonstrate two techniques:</p>
<ul>
<li>
<p>Using pandas for feature engineering on graph data, demonstrating basic pandas’ operations as well as some tricky computations on graph data.</p>
</li>
<li>
<p>Using sklearn for simple machine learning pipeline setup, with feature transforming, some simple modeling, model selection by grid search CV.</p>
</li>
</ul>
<h2>deepakmunjal15/Research-Paper-Extractor-Tool: Created a Research Paper Data Extractor Tool using Microsoft Academic API. Skills Used: Python</h2>
<p><a href="https://github.com/deepakmunjal15/Research-Paper-Extractor-Tool">https://github.com/deepakmunjal15/Research-Paper-Extractor-Tool</a></p>
<h2>michaelfaerber/makg-linking: Creating owl:sameAs <abbr title="[object Object]">links</abbr> beteen the Microsoft Academic Knowledge Graph (MAKG) and other Linked Open Data sources (OpenCitations, Wikidata, …)</h2>
<p><a href="https://github.com/michaelfaerber/makg-linking">https://github.com/michaelfaerber/makg-linking</a></p>
<h2>ben-var/VISR: Visualizing Institutional Scholar Relationships using D3.js, JavaScript, HTML, and CSS after processing 330GB of data from Microsoft Academic Graph using Hadoop and Python</h2>
<p><a href="https://github.com/ben-var/VISR">https://github.com/ben-var/VISR</a></p>
<h2>karankishinani/VISR: Visualizing Institutional Scholar Relationships using d3.js, JavaScript, HTML, and CSS after processing 330GB of data from Microsoft Academic Graph by Aminer</h2>
<p><a href="https://github.com/karankishinani/VISR">https://github.com/karankishinani/VISR</a></p>
<h2>whoyoung388/visualization-of-schools: Visualizing Institutional Scholar Relationships using D3.js, JavaScript, HTML, and CSS after processing 330GB of data from Microsoft Academic Graph using Hadoop and Python.</h2>
<p><a href="https://github.com/whoyoung388/visualization-of-schools">https://github.com/whoyoung388/visualization-of-schools</a></p>
<p>View the project live at <a href="http://whoyoung388.github.io/viz-of-schools/">whoyoung388.github.io/viz-of-schools/</a> It will take ~30s to download the data and load the graph. Press the blue “Load” button once the screen is no longer greyed out to display the graph for your selected field of study.</p>
<p>All the code for the project contained in the root directory.</p>
<p>Vizualizing the results (Visualization)</p>
<p>This project folder contains the code and the reduced dataset required to perform the analysis and visualization.</p>
<p>The clustering and preprocessing code takes an extensive amount of time and is included for reference purposes only if one desires to reperform our steps or to view how some of the code works. The original MAG file is very large (330GB) but can be freely found online. It can be found at <a href="https://aminer.org/open-academic-graph">https://aminer.org/open-academic-graph</a>.</p>
<h3>Analysis Notes</h3>
<p>I had spotted these 3 repositories, which seemed like forks, but technically are not, while they <strong>do</strong> seem to contain the same data. Probably independent github imports or some such…</p>
<h2>patwaria/pubcite: A .NET citation analyzer application for scholars. It parses citation information from Google Scholar, Microsoft Academic Research and CiteseerX to populate results.</h2>
<p><a href="https://github.com/patwaria/pubcite">https://github.com/patwaria/pubcite</a></p>
<h3>Analysis Notes</h3>
<p>7 years old code.</p>
<p>Has CAPTCHA detection and robot error report detection but otherwise looks like almost everyone else: vanilla.</p>
<p>Code is at <a href="https://github.com/patwaria/pubcite/blob/master/PubCite/PubCite/GSScraper.cs">https://github.com/patwaria/pubcite/blob/master/PubCite/PubCite/GSScraper.cs</a> and <a href="https://github.com/patwaria/pubcite/blob/master/PubCite/PubCite/GSAuthorPageScraper.cs">https://github.com/patwaria/pubcite/blob/master/PubCite/PubCite/GSAuthorPageScraper.cs</a></p>
<h2>lyeec9/EssayGenerator: Generates an essay of a specified topic and length through the use of Markov Chains, Machine Learning, and Microsoft Academic Search’sAPI.</h2>
<p><a href="https://github.com/lyeec9/EssayGenerator">https://github.com/lyeec9/EssayGenerator</a></p>
<h3>Analysis Notes</h3>
<p>Just a bit of <em>fun stuff</em> I wanted to have a look at…</p>
<h2>tobiagru/ArxivAnalyticsCluster: Tool to run analytics on top of papers from arXiv. Provides a dashboard to explore connections between papers and topics. The analytics run inside a spark cluster. The papers are enriched with the microsoft academic graph.</h2>
<p><a href="https://github.com/tobiagru/ArxivAnalyticsCluster">https://github.com/tobiagru/ArxivAnalyticsCluster</a></p>
<h2>cran/microdemic:  This is a read-only mirror of the CRAN R package repository. microdemic — ‘Microsoft Academic’ API Client. Homepage: <a href="https://github.com/ropensci/microdemic">https://github.com/ropensci/microdemic</a> (devel), <a href="https://docs.ropensci.org/microdemic">https://docs.ropensci.org/microdemic</a> (website) Report bugs for this package: <a href="https://github.com/ropensci/microdemic/issues">https://github.com/ropensci/microdemic/issues</a></h2>
<p><a href="https://github.com/cran/microdemic">https://github.com/cran/microdemic</a></p>
<h2>ninyancat13/deepfake-detection-challenge: Deepfake techniques, which present realistic AI-generated videos of people doing and saying fictional things, have the potential to have a significant impact on how people determine the legitimacy of information presented online. These content generation and modification technologies may affect the quality of public discourse and the safeguarding of human rights—especially given that deepfakes may be used maliciously as a source of misinformation, manipulation, harassment, and persuasion. Identifying manipulated media is a technically demanding and rapidly evolving challenge that requires collaborations across the entire tech industry and beyond. AWS, Facebook, Microsoft, the Partnership on AI’s Media Integrity Steering Committee, and academics have come together to build the Deepfake Detection Challenge (DFDC). The goal of the challenge is to spur researchers around the world to build innovative new technologies that can help detect deepfakes and manipulated media. - Kaggle Competiton Summary (<a href="https://www.kaggle.com/c/deepfake-detection-challenge">https://www.kaggle.com/c/deepfake-detection-challenge</a>)</h2>
<p><a href="https://github.com/ninyancat13/deepfake-detection-challenge">https://github.com/ninyancat13/deepfake-detection-challenge</a></p>
<h3>Analysis Notes</h3>
<p>Only a README, nothing else yet after 7 months!</p>
<h2>Microsoft Academic Search · timrdf/locv Wiki</h2>
<p><a href="https://github.com/timrdf/locv/wiki/Microsoft-Academic-Search">https://github.com/timrdf/locv/wiki/Microsoft-Academic-Search</a></p>
<p><a href="https://github.com/karpathy/researchlei/issues/4">https://github.com/karpathy/researchlei/issues/4</a> - Microsoft Academic Search is being retired</p>
<p>see <a href="https://github.com/karpathy/researchlei/issues/4">https://github.com/karpathy/researchlei/issues/4</a></p>
<p>Pull the citation network from:</p>
<ul>
<li>CVPR</li>
<li>ICCV</li>
<li>ECCV</li>
<li>ISWC: 360</li>
<li>IPAW: 2113</li>
<li>2242 PSSS Practical and Scalable Semantic Systems</li>
<li>3 IAWTIC International Conference on Intelligent Agents, Web Technologiesand Internet Commerce</li>
<li>46 ICWE International Conference on Web Engineering</li>
<li>49 ICWS International Conference on Web Services</li>
<li>476 WAIM Web-Age Information Management</li>
<li>487 WES Web Services, E-Business, and the Semantic Web</li>
<li>483 WebDB International Workshop on the Web and Databases</li>
<li>494 WIDM Web Information and Data Management</li>
<li>490 WI Web Intelligence</li>
<li>496 WIIW Workshop on Information Integration on the Web</li>
<li>526 WWW World Wide Web Conference Series</li>
<li>633 DIWeb Data Integration over the Web</li>
<li>1956 ESWS European Semantic Web Symposium / Conference</li>
<li>2499 SWAP Semantic Web Applications and Perspectives</li>
</ul>
<p>API User Manual</p>
<p><a href="http://academic.research.microsoft.com/About/Help.htm">http://academic.research.microsoft.com/About/Help.htm</a></p>
<p>All our APIs come with the standard 200 queries per minute.</p>
<p>Each API call returns only 100 items per call.</p>
<p>The dataset is available from <a href="https://datamarket.azure.com/dataset/mrc/microsoftacademic">https://datamarket.azure.com/dataset/mrc/microsoftacademic</a> after you sign up for an Azure account and “buy” the free subscription to the dataset.</p>
<p><a href="https://journal.code4lib.org/articles/7738">A Comparison of Article Search APIs via Blinded Experiment and Developer Review</a></p>
<h2>Citation Search · pubgem/project-guide Wiki</h2>
<p><a href="https://github.com/pubgem/project-guide/wiki/Citation-Search">https://github.com/pubgem/project-guide/wiki/Citation-Search</a></p>
<h2>Read · wikihub/eduwiki Wiki</h2>
<p><a href="https://github.com/wikihub/eduwiki/wiki/Read">https://github.com/wikihub/eduwiki/wiki/Read</a></p>
<p><a href="https://github.com/wikihub/eduwiki.wiki.git">https://github.com/wikihub/eduwiki.wiki.git</a></p>
<p>A wiki for the everyday life of students, junior and senior:</p>
<ul>
<li>Learn</li>
<li>Read</li>
<li>Watch</li>
<li>Research</li>
<li>Build</li>
<li>Code</li>
<li>Draw</li>
<li>Write</li>
<li>Present</li>
<li>Work</li>
</ul>
<p>We use MediaWiki or Markdown markup on this wiki. Here is a tutorial on editting MediaWiki pages and here, you can find the basics about Markdown.</p>
<h2>Writing in LaTeX · cognitionemotionlab/lab-docs Wiki</h2>
<p><a href="https://github.com/cognitionemotionlab/lab-docs/wiki/Writing-in-LaTeX">https://github.com/cognitionemotionlab/lab-docs/wiki/Writing-in-LaTeX</a></p>
<p><a href="https://github.com/cognitionemotionlab/lab-docs.wiki.git">https://github.com/cognitionemotionlab/lab-docs.wiki.git</a></p>
<p>This repository is built solely for the purpose of housing the Cognition &amp; Emotion Lab’s WIKI.</p>
<p>You can see the Wiki at <a href="https://github.com/cognitionemotionlab/lab-docs.wiki.git">https://github.com/cognitionemotionlab/lab-docs.wiki.git</a></p>
<p><a href="https://www.overleaf.com/learn/latex/Learn_LaTeX_in_30_minutes">https://www.overleaf.com/learn/latex/Learn_LaTeX_in_30_minutes</a></p>
<h2>acite · bavla/biblio Wiki</h2>
<p><a href="https://github.com/bavla/biblio/wiki/acite">https://github.com/bavla/biblio/wiki/acite</a></p>
<h2>Patented Foolishness · sgml/signature Wiki</h2>
<p><a href="https://github.com/sgml/signature/wiki/Patented-Foolishness">https://github.com/sgml/signature/wiki/Patented-Foolishness</a></p>
<h2>microsoft/psi - Platform for Situated Intelligence</h2>
<p><a href="https://github.com/microsoft/psi">https://github.com/microsoft/psi</a></p>
<p><strong>Platform for Situated Intelligence</strong> is an open, extensible framework that enables the development, fielding and study of multimodal, integrative-AI systems.</p>
<p>In recent years, we have seen significant progress with machine learning techniques on various perceptual and control problems. At the same time, building end-to-end, multimodal, integrative-AI systems that leverage multiple technologies and act autonomously or interact with people in the open world remains a challenging, error-prone and time-consuming engineering task. Numerous challenges stem from the sheer complexity of these systems and are amplified by the lack of appropriate infrastructure and development tools.</p>
<p>The Platform for Situated Intelligence project aims to address these issues and provide a basis for <strong>developing, fielding and studying multimodal, integrative-AI systems</strong>. The platform consists of three layers. The <strong>Runtime</strong> layer provides a parallel programming model centered around temporal streams of data, and enables easy development of components and applications using .NET, while retaining the performance properties of natively written, carefully tuned systems. A set of <strong>Tools</strong> enable multimodal data visualization, annotations, analytics, tuning and machine learning scenarios. Finally, an open ecosystem of <strong>Components</strong> encapsulate various AI technologies and allow for quick compositing of integrative-AI applications.</p>
<p>For more information about the goals of the project, the types of systems that you can build using it, and the various layers see <a href="https://github.com/microsoft/psi/wiki/Platform-Overview">Platform for Situated Intelligence Overview</a>.</p>
<h1>Using and Building</h1>
<p>Platform for Situated Intelligence is built on the .NET Framework. Large parts of it are built on .NET Standard and therefore run both on Windows and Linux, whereas some components are specific and available only to one operating system.</p>
<p>You can build applications based on Platform for Situated Intelligence either by leveraging nuget packages, or by cloning and building the code. Below are instructions:</p>
<ul>
<li><a href="https://github.com/microsoft/psi/wiki/Using-via-NuGet-Packages">Using \psi via Nuget packages</a></li>
<li><a href="https://github.com/microsoft/psi/wiki/Building-the-Codebase">Building the \psi codebase</a></li>
</ul>
<h1>Documentation and Getting Started</h1>
<p>The documentation for Platform for Situated Intelligence is available in the <a href="https://github.com/microsoft/psi/wiki">github project wiki</a>. The documentation is still under construction and in various phases of completion. If you need further explanation in any area, please open an issue and label it <code>documentation</code>, as this will help us target our documentation development efforts to the highest priority needs.</p>
<p>To learn about Platform for Situated Intelligence, we recommend you begin with the <a href="https://github.com/microsoft/psi/wiki/Brief-Introduction">Brief Introduction</a>, which provides a guided walk-through for some of the main concepts in \psi. It shows how to create a simple program, describes the core concept of a stream, and explains how to transform, synchronize, visualize, persist and replay streams from disk. We recommend that you first work through the examples in this tutorial to familiarize yourself with these core concepts.</p>
<p>In addition, a number of tutorials, samples, and other resources can help you learn more about the framework, as described below:</p>
<p><strong>Tutorials</strong>. Several <a href="https://github.com/microsoft/psi/wiki/Tutorials">tutorials</a> are available to help you get started with using Platform for Situated Intelligence. You can begin with the <a href="https://github.com/microsoft/psi/wiki/Writing-Components">Writing Components</a> tutorial, which explains how to write new \psi components, and the <a href="https://github.com/microsoft/psi/wiki/Pipeline-Execution">Pipeline-Execution</a> and <a href="https://github.com/microsoft/psi/wiki/Delivery-Policies">Delivery Policies</a> tutorials, which describe how to control the execution of pipelines and how to control throughput on streams in your application. A number of additional tutorials provide information about the set of <a href="https://github.com/microsoft/psi/wiki/Basic-Stream-Operators">basic stream operators</a> available in the framework, as well as operators for <a href="https://github.com/microsoft/psi/wiki/Stream-Fusion-and-Merging">stream fusion and merging</a>, <a href="https://github.com/microsoft/psi/wiki/Interpolation-and-Sampling">interpolation and sampling</a>, <a href="https://github.com/microsoft/psi/wiki/Windowing-Operators">windowing</a>, and <a href="https://github.com/microsoft/psi/wiki/Stream-Generators">stream generation</a>.</p>
<p><strong>Other Topics</strong>. Several documents provide information about various specialized scenarios such as running distributed applications via <a href="https://github.com/microsoft/psi/wiki/Remoting">remoting</a>, <a href="https://github.com/microsoft/psi/wiki/Interop">bridging to Python, JS, etc.</a>, <a href="https://github.com/microsoft/psi/wiki/Shared-Objects">shared objects and memory management</a>, etc.</p>
<p><strong>Samples</strong>. Besides the tutorials and other topics, it may be helpful to look through the set of <a href="https://github.com/microsoft/psi/wiki/Samples">Samples</a> provided. While some of the samples address specialized topics such as how to leverage speech recognition components or how to bridge to ROS, reading them will give you more insight into programming with \psi. In addition, some of the samples have a corresponding detailed walkthrough that explains how the samples are constructed and function, and provide further pointers to documentation and learning materials. Going through these walkthroughs can also help you learn more about programming with Platform for Situated Intelligence.</p>
<h2>manubot/rootstock: Clone me to create your Manubot manuscript</h2>
<p><a href="https://github.com/manubot/rootstock">https://github.com/manubot/rootstock</a></p>
<p>This repository is a template manuscript (a.k.a. rootstock).
Actual manuscript instances will clone this repository (see <a href="SETUP.md"><code>SETUP.md</code></a>) and replace this paragraph with a description of their manuscript.</p>
<h3>Manubot</h3>
<p>Manubot is a system for writing scholarly manuscripts via GitHub.
Manubot automates citations and references, versions manuscripts using git, and enables collaborative writing via GitHub.
An <a href="https://greenelab.github.io/meta-review/" title="Open collaborative writing with Manubot">overview manuscript</a> presents the benefits of collaborative writing with Manubot and its unique features.
The <a href="https://git.io/fhQH1">rootstock repository</a> is a general purpose template for creating new Manubot instances, as detailed in <a href="SETUP.md"><code>SETUP.md</code></a>.
See <a href="USAGE.md"><code>USAGE.md</code></a> for documentation how to write a manuscript.</p>
<h3>Analysis Notes</h3>
<p>Had picked this one as one of the off-topic “fun bits” to check out and I like it: this is very close to what I’ve been looking for when it comes to writing papers.</p>
<p>Commended. To be checked out further at a later date when there’s time for more <em>fun stuff</em>.</p>
<p><strong>Extra</strong>: check out <a href="https://github.com/bokeh/bokeh">https://github.com/bokeh/bokeh</a>, which is Python, alas. Compare to D3 et al…</p>
<h1>DOI to citation</h1>
<h2>ms609/citation-bot: Citation bot is a tool to expand and format references at Wikipedia. It retrieves citation data from a variety of sources including CrossRef (DOI), PMID, PMC and JSTOR, and returns a formatted citation. Report bugs at <a href="https://en.wikipedia.org/wiki/User_talk:Citation_bot">https://en.wikipedia.org/wiki/User_talk:Citation_bot</a></h2>
<p><a href="https://github.com/ms609/citation-bot">https://github.com/ms609/citation-bot</a></p>
<h2>Apoc2400/Reftag: Wikipedia citation tool for Google Books, New York Times, ISBN, DOI and more</h2>
<p><a href="https://github.com/Apoc2400/Reftag">https://github.com/Apoc2400/Reftag</a></p>
<h2>ropensci/handlr: convert among citation formats</h2>
<p><a href="https://github.com/ropensci/handlr">https://github.com/ropensci/handlr</a></p>
<p>a tool for converting among citation formats.</p>
<p>heavily influenced by, and code ported from <a href="https://github.com/datacite/bolognese">https://github.com/datacite/bolognese</a></p>
<p>supported readers:</p>
<ul>
<li>[citeproc][]</li>
<li>[ris][]</li>
<li>[bibtex][]</li>
<li>[codemeta][]</li>
</ul>
<p>supported writers:</p>
<ul>
<li>[citeproc][]</li>
<li>[ris][]</li>
<li>[bibtex][]</li>
<li>[<a href="http://schema.org">schema.org</a>][]</li>
<li>[rdfxml][] (requires suggested package [jsonld][])</li>
<li>[codemeta][]</li>
</ul>
<p>not supported yet, but plan to:</p>
<ul>
<li>crosscite</li>
</ul>
<h2>papis/papis: Powerful and highly extensible command-line based document and bibliography manager.</h2>
<p><a href="https://github.com/papis/papis">https://github.com/papis/papis</a></p>
<h3>Main features</h3>
<ul>
<li>Synchronizing of documents: put your documents in some folder and
synchronize it using the tools you love: git, dropbox, rsync,
OwnCloud, Google Drive … whatever.</li>
<li>Share libraries with colleagues without forcing them to open an
account, nowhere, never.</li>
<li>Download directly paper information from <em>DOI</em> number via <em>Crossref</em>.</li>
<li>(optional) <strong>scihub</strong> support, use the example papis script
<code>examples/scripts/papis-scihub</code> to download papers from scihub and
add them to your library with all the relevant information, in a
matter of seconds, also you can check the documentation
<a href="http://papis.readthedocs.io/en/latest/scihub.html">here</a>.</li>
<li>Import from Zotero and other managers using
<a href="https://github.com/papis/papis-zotero">papis-zotero</a>.</li>
<li>Create custom scripts to help you achieve great tasks easily
(<a href="http://papis.readthedocs.io/en/latest/scripting.html">doc</a>).</li>
<li>Export documents into many formats (bibtex, yaml..)</li>
<li>Command-line granularity, all the power of a library at the tip of
your fingers.</li>
</ul>
<h2>dotcs/doimgr: Command line tool using <a href="http://crossref.org">crossref.org</a>’s API to search DOIs and obtain formatted citations such as bibtex, apa, and a lot more</h2>
<p><a href="https://github.com/dotcs/doimgr">https://github.com/dotcs/doimgr</a></p>
<h2>nushio3/citation-resolve: convert document identifiers such as DOI, ISBN, arXiv ID to bibliographic reference.</h2>
<p><a href="https://github.com/nushio3/citation-resolve">https://github.com/nushio3/citation-resolve</a></p>
<p>convert document identifiers such as DOI, ISBN, arXiv ID to bibliographic reference.</p>
<h2>CrossRef/reddit-dump-experiment: Experimental extraction of DOI citation information from Reddit submission dump.</h2>
<p><a href="https://github.com/CrossRef/reddit-dump-experiment">https://github.com/CrossRef/reddit-dump-experiment</a></p>
<p>Quick analysis to look at the use of DOIs in Reddit submissions over time. Can be run locally using these instructions or on a cluster using instructions found in Spark docs.</p>
<p>Code here is a little hacky, but does the job. Suggestions welcome.</p>
<h2>foucault/citation: Generate bibtex entries from Document Object Identifiers (DOI)</h2>
<p><a href="https://github.com/foucault/citation">https://github.com/foucault/citation</a></p>
<p>citation is a dead simple Python script used to download readily formatted citations for use in bibtex just by providing its Document Object Identifier (DOI). Cut and paste the output into your .bib file and you are ready to go!</p>
<h2>haqle314/doi2citation</h2>
<p><a href="https://github.com/haqle314/doi2citation">https://github.com/haqle314/doi2citation</a></p>
<p>Just a one-liner shell script to query the API available at <a href="https://doi.org">doi.org</a> for the citation text for a DOI.</p>
<h2>Lachlan00/EasyCite: Easily download academic citation bib files and pdfs from DOIs</h2>
<p><a href="https://github.com/Lachlan00/EasyCite">https://github.com/Lachlan00/EasyCite</a></p>
<p>A simple Python script to download bibtex citations and paper PDFs. Bibtex files pulled from <a href="http://dx.doi.org/">http://dx.doi.org</a> and PDFs downloaded from SciHub using <a href="https://pypi.org/project/scidownl/">scidownl</a>.</p>
<h2>machnine/citationgen: Generate citation files from doi/pmid etc.</h2>
<p><a href="https://github.com/machnine/citationgen">https://github.com/machnine/citationgen</a></p>
<h2>kjgarza/doi-citation</h2>
<p><a href="https://github.com/kjgarza/doi-citation">https://github.com/kjgarza/doi-citation</a></p>
<h2>pierre-24/goto-publication: Citation-based URL/DOI searches</h2>
<p><a href="https://github.com/pierre-24/goto-publication">https://github.com/pierre-24/goto-publication</a></p>
<p><em>Citation-based URL/DOI searches</em>, by <code>Pierre Beaujean &lt;https://pierrebeaujean.net&gt;</code>.
CLI version of <a href="https://github.com/pierre-24/goto-publication-old/">that previous project</a>.</p>
<p>Because the journal, the volume and the page (and, sometimes, yeah, the issue) should be enough to find an article (for which, of course, you don’t have the DOI).</p>
<p>Since I have a (quantum) chemistry background, I will limit this project to the journals that are in the chemistry and physics fields.
I’m working on that, but feel free to propose <a href="https://github.com/pierre-24/goto-publication/pulls">improvements</a>.</p>
<h2>ropenscilabs/rcitoid: Citation data via Wikimedia using the Citoid service</h2>
<p><a href="https://github.com/ropenscilabs/rcitoid">https://github.com/ropenscilabs/rcitoid</a></p>
<p>Client for the Citoid service <a href="https://www.mediawiki.org/wiki/Citoid">https://www.mediawiki.org/wiki/Citoid</a></p>
<p>docs: <a href="https://en.wikipedia.org/api/rest_v1/#!/Citation/getCitation">https://en.wikipedia.org/api/rest_v1/#!/Citation/getCitation</a></p>
<h2>pierre-24/goto-publication-old: Citation-based DOI searches and redirections</h2>
<p><a href="https://github.com/pierre-24/goto-publication-old">https://github.com/pierre-24/goto-publication-old</a></p>
<p>Citation-based URL/DOI searches and redirections, by Pierre Beaujean.</p>
<p>Because the journal, the volume and the page should be enough to find an article (for which, of course, you don’t have the DOI, otherwise this is stupid).</p>
<p>Note: Since I have a (quantum) chemistry background, I will limit this project to the journals that are in the chemistry and physics fields. Feel free to fork the project if you want something else 😃</p>
<h2>gaberoo/doitex: Use doi citations in Latex and fetch automatically from CrossRef.</h2>
<p><a href="https://github.com/gaberoo/doitex">https://github.com/gaberoo/doitex</a></p>
<h2>exquisapp/CitationApp: A Node Js Application That Uses Zotero’s Translation Server To Easily Cite When Queried With Sources Like URI, DOI, ISBN, Titles …and so on.</h2>
<p><a href="https://github.com/exquisapp/CitationApp">https://github.com/exquisapp/CitationApp</a></p>
<h2>cityofaustin/doi-automation: automation for DataCite DOI citation integration with Socrata</h2>
<p><a href="https://github.com/cityofaustin/doi-automation">https://github.com/cityofaustin/doi-automation</a></p>
<p>Datacite (<a href="https://en.wikipedia.org/wiki/DataCite">https://en.wikipedia.org/wiki/DataCite</a>) is a non profit organization which provides an easy way to register, cite, and access datasets online.
The City of Austin would like to use this organization’s tools to garner insight into the usage of our open data as well as give the public a simple and effective way to cite our open data for any use.</p>
<p>To see some examples of our citations see:
<a href="https://search.datacite.org/members/austintx">https://search.datacite.org/members/austintx</a></p>
<p>This project’s goal is to explore and implement an integration between DataCite’s citation repository and the city’s Socrata Open Data portal (<a href="https://data.austintexas.gov/">https://data.austintexas.gov/</a>). This will be done by developing automation to synchronize datacite’s DOI repository with the City of Austin’s socrata portal assets and metadata using the two organization’s APIs and a python backend.</p>
<p>Socrata Discovery API:
<a href="https://socratadiscovery.docs.apiary.io/#">https://socratadiscovery.docs.apiary.io/#</a></p>
<p>DataCite REST API:
<a href="https://support.datacite.org/docs/api">https://support.datacite.org/docs/api</a></p>
<h2>dvdmrn/citation_scraper: searches pdfs for their doi and attempts to find a pubmed citation</h2>
<p><a href="https://github.com/dvdmrn/citation_scraper">https://github.com/dvdmrn/citation_scraper</a></p>
<h3>Dependencies:</h3>
<ul>
<li>Python 2</li>
<li>Scholarly (Install by opening a terminal window and typing <code>pip install scholarly</code>)</li>
<li>metapub (Install with the same method)</li>
<li>pdfminer (Install with the same method)</li>
</ul>
<h3>How to use:</h3>
<ul>
<li>Place all the unprocessed pdfs you want to analyze into the folder <code>pdfs_to_analyze</code></li>
<li>Open the program in terminal by typing <code>python citation_scraper.py</code></li>
<li>Enter the name that you would like to call your output .csv file</li>
<li>A new file will be created in the directory containing <code>citation_scraper.py</code></li>
<li>Just relax</li>
</ul>
<h2>JPFrancoia/reftool: ref2pdf returns a DOI from a formatted citation.</h2>
<p><a href="https://github.com/JPFrancoia/reftool">https://github.com/JPFrancoia/reftool</a></p>
<p>reftool is a simple script to return a DOI from a formatted citation. It can also return a direct link to download the article from Sci-Hub (this option could be illegal, use at your own risk).</p>
<p>This script uses <a href="https://doi.crossref.org/simpleTextQuery">Crossref’s Simple Text Query Tool</a>.</p>
<p>Usage is limited to 1000 requests per user/per month, and requires signing up on Crossref’s website. The script needs the email address you used to sign up.</p>
<h2>cran/citation:  This is a read-only mirror of the CRAN R package repository. citation — Software Citation Tools. Homepage: <a href="https://github.com/pik-piam/citation">https://github.com/pik-piam/citation</a>, <a href="https://doi.org/10.5281/zenodo.3813429">https://doi.org/10.5281/zenodo.3813429</a> Report bugs for this package: <a href="https://github.com/pik-piam/citation/issues">https://github.com/pik-piam/citation/issues</a></h2>
<p><a href="https://github.com/cran/citation">https://github.com/cran/citation</a></p>
<h2>ETspielberg/title2doi: A backend service to transform a list of citations to dois and further to mods via scopus</h2>
<p><a href="https://github.com/ETspielberg/title2doi">https://github.com/ETspielberg/title2doi</a></p>
<p>A small FLASK web service, taking a filename from the POST request, loads the corresponding file from the LIBINTEL_:UPLOAD_DIR directory containing an unformatted list of references.</p>
<p>each reference (= each line) is queried at the CrossRef-API to retrieve the corresponding DOI. If a DOI is found, the MyCoRe repository is queried, whether it contains the entry. In addition, Scopus is queried to retrieve the Scopus ID and actual citation counts. Results are written to the results.txt as spread sheet ascii (delimited by 😉.</p>
<h2>YutoMizutani/getdoi: A tool for getting the academic article’s DOI from citation text.</h2>
<p><a href="https://github.com/YutoMizutani/getdoi">https://github.com/YutoMizutani/getdoi</a></p>
<h2>cbosoft/bibget.py: Fetches citation data given a pdf or doi, returns in bibTeX format.</h2>
<p><a href="https://github.com/cbosoft/bibget.py">https://github.com/cbosoft/bibget.py</a></p>
<h2>joesingo/paperfinder: Script to find the DOI and BibTeX citation for a paper given it’s URL on the publisher’s website</h2>
<p><a href="https://github.com/joesingo/paperfinder">https://github.com/joesingo/paperfinder</a></p>
<p>iven a URL to a paper on a publisher’s website, find its DOI and a BibTex citation. Output can be given as plain text or JSON.</p>
<p>This takes some of the pain out of dealing with publishers’ websites. Of course, it is possible to pair this tool with SciHub to get the actual PDF (go to <a href="https://sci-hub.se/">https://sci-hub.se/</a><DOI>), but I could not possibly endorse piracy in this way…</p>
<p>Note that pf works for a very small number of publishers, and may break if publisher web pages or URLs change.</p>
<p>Supported publishers</p>
<ul>
<li>ScienceDirect</li>
<li>Springer</li>
</ul>
<h2>NANCYVALDEBENITO/articles_scopus_wos: Look for articles with scopus and web of science using python selenium. Only with DOI you can obtain affiliations, total citations, journal name and journal Rank, Journal Impact Factory … among others</h2>
<p><a href="https://github.com/NANCYVALDEBENITO/articles_scopus_wos">https://github.com/NANCYVALDEBENITO/articles_scopus_wos</a></p>
<h2>NationalLimerickProductions/seq2cite: seq2cite is a citation recommendation engine that improves upon the word of Ebisu &amp; Fang (2017) (<a href="https://dl.acm.org/doi/abs/10.1145/3077136.3080730">https://dl.acm.org/doi/abs/10.1145/3077136.3080730</a>) to recommend citations from small pieces of scientific text. We demonstrate our system with the CORD-19 dataset of articles related to COVID-19.</h2>
<p><a href="https://github.com/NationalLimerickProductions/seq2cite">https://github.com/NationalLimerickProductions/seq2cite</a></p>
<h1>keyword extraction</h1>
<h2>AimeeLee77/keyword_extraction: 利用Python实现中文文本关键词抽取，分别采用TF-IDF、TextRank、Word2Vec词聚类三种方法。</h2>
<p><a href="https://github.com/AimeeLee77/keyword_extraction">https://github.com/AimeeLee77/keyword_extraction</a></p>
<h2>bigzhao/Keyword_Extraction: 神策杯2018高校算法大师赛（中文关键词提取）第二名代码方案</h2>
<p><a href="https://github.com/bigzhao/Keyword_Extraction">https://github.com/bigzhao/Keyword_Extraction</a></p>
<h2>aneesha/RAKE: A python implementation of the Rapid Automatic Keyword Extraction</h2>
<p><a href="https://github.com/aneesha/RAKE">https://github.com/aneesha/RAKE</a></p>
<h2>LIAAD/yake: Single-document unsupervised keyword extraction</h2>
<p><a href="https://github.com/LIAAD/yake">https://github.com/LIAAD/yake</a></p>
<p>Unsupervised Approach for Automatic Keyword Extraction using Text Features.</p>
<p>YAKE! is a light-weight unsupervised automatic keyword extraction method which rests on text statistical features extracted from single documents to select the most important keywords of a text. Our system does not need to be trained on a particular set of documents, neither it depends on dictionaries, external-corpus, size of the text, language or domain. To demonstrate the merits and the significance of our proposal, we compare it against ten state-of-the-art unsupervised approaches (TF.IDF, KP-Miner, RAKE, TextRank, SingleRank, ExpandRank, TopicRank, TopicalPageRank, PositionRank and MultipartiteRank), and one supervised method (KEA). Experimental results carried out on top of twenty datasets (see Benchmark section below) show that our methods significantly outperform state-of-the-art methods under a number of collections of different sizes, languages or domains.</p>
<h3>Main Features</h3>
<ul>
<li>Unsupervised approach</li>
<li>Corpus-Independent</li>
<li>Domain and Language Independent</li>
<li>Single-Document</li>
</ul>
<h3>Benchmark</h3>
<p>YAKE!, generically outperforms, statistical methods [tf.idf (in 100% of the datasets), kp-miner (in 55%) and rake (in 100%)], state-of-the-art graph-based methods [TextRank (in 100% of the datasets), SingleRank (in 90%), TopicRank (in 70%), TopicalPageRank (in 90%), PositionRank (in 90%), MultipartiteRank (in 75%) and ExpandRank (in 100%)] and supervised learning methods [KEA (in 70% of the datasets)] across different datasets, languages and domains. The results listed in the table refer to F1 at 10 scores. Bold face marks the current best results for that specific dataset. The column “Method” cites the work of the previous (or current) best method (depending where the bold face is found). The interested reader should refer to <a href="https://github.com/LIAAD/yake/blob/master/docs/YAKEvsBaselines.jpg"><strong>this table</strong></a> in order to see a detailed comparison between YAKE and all the state-of-the-art methods.</p>
<h2>boudinfl/pke: Python Keyphrase Extraction module</h2>
<p><a href="https://github.com/boudinfl/pke">https://github.com/boudinfl/pke</a></p>
<p>pke is an open source python-based keyphrase extraction toolkit. It provides an end-to-end keyphrase extraction pipeline in which each component can be easily modified or extended to develop new models. pke also allows for easy benchmarking of state-of-the-art keyphrase extraction models, and ships with supervised models trained on the SemEval-2010 dataset.</p>
<h3>Implemented models</h3>
<p>pke currently implements the following keyphrase extraction models:</p>
<ul>
<li>Unsupervised models
<ul>
<li>Statistical models
<ul>
<li>TfIdf [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#tfidf">documentation</a>]</li>
<li>KPMiner [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#kpminer">documentation</a>, <a href="http://www.aclweb.org/anthology/S10-1041.pdf">article by (El-Beltagy and Rafea, 2010)</a>]</li>
<li>YAKE [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#yake">documentation</a>, <a href="https://doi.org/10.1016/j.ins.2019.09.013">article by (Campos et al., 2020)</a>]</li>
</ul>
</li>
<li>Graph-based models
<ul>
<li>TextRank [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#textrank">documentation</a>, <a href="http://www.aclweb.org/anthology/W04-3252.pdf">article by (Mihalcea and Tarau, 2004)</a>]</li>
<li>SingleRank  [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#singlerank">documentation</a>, <a href="http://www.aclweb.org/anthology/C08-1122.pdf">article by (Wan and Xiao, 2008)</a>]</li>
<li>TopicRank [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#topicrank">documentation</a>, <a href="http://aclweb.org/anthology/I13-1062.pdf">article by (Bougouin et al., 2013)</a>]</li>
<li>TopicalPageRank [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#topicalpagerank">documentation</a>, <a href="http://users.intec.ugent.be/cdvelder/papers/2015/sterckx2015wwwb.pdf">article by (Sterckx et al., 2015)</a>]</li>
<li>PositionRank [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#positionrank">documentation</a>, <a href="http://www.aclweb.org/anthology/P17-1102.pdf">article by (Florescu and Caragea, 2017)</a>]</li>
<li>MultipartiteRank [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#multipartiterank">documentation</a>, <a href="https://arxiv.org/abs/1803.08721">article by (Boudin, 2018)</a>]</li>
</ul>
</li>
</ul>
</li>
<li>Supervised models
<ul>
<li>Feature-based models
<ul>
<li>Kea [<a href="https://boudinfl.github.io/pke/build/html/supervised.html#kea">documentation</a>, <a href="https://www.cs.waikato.ac.nz/ml/publications/2005/chap_Witten-et-al_Windows.pdf">article by (Witten et al., 2005)</a>]</li>
<li>WINGNUS [<a href="https://boudinfl.github.io/pke/build/html/supervised.html#wingnus">documentation</a>, <a href="http://www.aclweb.org/anthology/S10-1035.pdf">article by (Nguyen and Luong, 2010)</a>]</li>
</ul>
</li>
</ul>
</li>
</ul>
<h2>zelandiya/keyword-extraction-datasets: Different datasets for developing and testing keyword extraction algorithms</h2>
<p><a href="https://github.com/zelandiya/keyword-extraction-datasets">https://github.com/zelandiya/keyword-extraction-datasets</a></p>
<h2>ibatra/BERT-Keyword-Extractor: Deep Keyphrase Extraction using BERT</h2>
<p><a href="https://github.com/ibatra/BERT-Keyword-Extractor">https://github.com/ibatra/BERT-Keyword-Extractor</a></p>
<h2>Keyword Extraction Datasets</h2>
<p><a href="https://github.com/zelandiya/keyword-extraction-datasets">https://github.com/zelandiya/keyword-extraction-datasets</a></p>
<p>Different datasets for developing, evaluating and testing keyword extraction algorithms. For benchmarking performance see: O. Medelyan. 2009. Human-competitive automatic topic indexing. PhD Thesis. University of Waikato, New Zealand.</p>
<p>Extracting keywords using a controlled vocabulary or a thesaurus as a source:</p>
<p>NLM_500.zip - 500 PubMed documents with MeSH terms</p>
<p>fao780.tar.gz - 780 FAO publications with Agrovoc terms</p>
<p>fao30.tar.gz - 30 FAO publications, each annotated by 6 professional FAO indexers</p>
<p>Free-text keyword extraction (without a vocabulary):</p>
<p>citeulike180.tar.gz - 180 publications crawled from CiteULike, and keywords assigned by different CiteULike users who saved these publications</p>
<p>SemEval2010-Maui.zip - SemEval-2010 Keyphrase extraction track data in Maui format</p>
<p>keyphrextr.tar.gz - Keyphrase extraction model created using SemEval-2010 training data. This model is used in the Maui GPL demo when no vocabulary is selected.</p>
<p>Extracting keywords using Wikipedia as a controlled vocabulary of allowed terms:</p>
<p>wiki20.tar.gz - 20 Computer Science papers, each annotated with at least 5 Wikipedia articles by 15 teams of indexers</p>
<h2>JRC1995/TextRank-Keyword-Extraction: Keyword extraction using TextRank algorithm after pre-processing the text with lemmatization, filtering unwanted parts-of-speech and other techniques.</h2>
<p><a href="https://github.com/JRC1995/TextRank-Keyword-Extraction">https://github.com/JRC1995/TextRank-Keyword-Extraction</a></p>
<p>Based on: “TextRank: Bringing Order into Texts - by Rada Mihalcea and Paul Tarau”</p>
<h2>demoyhui/KeywordExtraction: 基于LDA和TextRank的关键子提取算法实现</h2>
<p><a href="https://github.com/demoyhui/KeywordExtraction">https://github.com/demoyhui/KeywordExtraction</a></p>
<h2>Ismael-Hery/rake-keywords: Javascript implementation of the “Rake” keywords extraction algorithm</h2>
<p><a href="https://github.com/Ismael-Hery/rake-keywords">https://github.com/Ismael-Hery/rake-keywords</a></p>
<p>Some problems with the Rake original scientific paper</p>
<p>Errors in the paper</p>
<ul>
<li>
<p>‘numbers’ is a stop word in the original Fox stop words list, thus ‘natural numbers’ can not be a candidate keywords. I removed numbers from the Fox stop list as they probably did for the paper (otherwise they would not have found ‘natural numbers’)</p>
</li>
<li>
<p>the paper does not find mixed types as a candidate keywords. I’ve added mixed types as a candidates key words</p>
</li>
<li>
<p>Non english language</p>
</li>
</ul>
<p>TODO :</p>
<ul>
<li>compute keywords from a corpus of articles (see sci paper with computation of ‘essential’ keywords)</li>
<li>French implementation with ‘mots de liaisons’ du/des/d’/… excluded from stop list</li>
</ul>
<h2>waseem18/node-rake: A NodeJS implementation of the Rapid Automatic Keyword Extraction algorithm.</h2>
<p><a href="https://github.com/waseem18/node-rake">https://github.com/waseem18/node-rake</a></p>
<h2>sleepycat/rapid-automated-keyword-extraction: A Javascript implementation of the Rapid Automated Keyword Extraction (RAKE) algorithm</h2>
<p><a href="https://github.com/sleepycat/rapid-automated-keyword-extraction">https://github.com/sleepycat/rapid-automated-keyword-extraction</a></p>
<h2>shopping24/rake-js: JS Implementation of the Rapid Automatic Keyword Extraction Paper</h2>
<p><a href="https://github.com/shopping24/rake-js">https://github.com/shopping24/rake-js</a></p>
<p>RAKE is the acronym for Rapid Automated Keyword Extraction. The basic algorithm is described by Stuart Rose, Dave Engel, Nick Cramer and Wendy Cowley in their paper “Automatic keyword extraction from individual documents” (©2010, John Wiley &amp; Sons, Ltd, Source click here).</p>
<p>In short RAKE describes splitting a text into fragments by stop words. Stop words are always considered to be irrelevant to the context. The RAKEd result of Red Zebra and Jaguar would therefore be [Red Zebra, Jaguar].</p>
<p>The score is then calculated by counting the individual words and and creating degrees based on the length of found fragments.</p>
<h3>What is this repository about?</h3>
<p>This repository includes advanced methods in addition to the original RAKE description. Furthermore we added a functional wrapper as feature for a more flexible way of handling keyword extraction. The process consists of these steps:</p>
<ul>
<li>Extracting fragments from any given text using various available methods.</li>
<li>Score the fragments.</li>
<li>Retrieve the end result.</li>
</ul>
<p>Extraction and scoring functions from any source making use of the Phrases and Phrase classes may be used and executed in the desired order.</p>
<h2>colefichter/NRake: A C# implementation of Rapid Automatic Keyword Extraction (RAKE)</h2>
<p><a href="https://github.com/colefichter/NRake">https://github.com/colefichter/NRake</a></p>
<p>This is an implementation based on the algorithm described in the paper “Automatic keyword extraction from individual documents” <a href="http://media.wiley.com/product_data/excerpt/22/04707498/0470749822.pdf">http://media.wiley.com/product_data/excerpt/22/04707498/0470749822.pdf</a>.</p>
<h2>benmcevoy/Rake: A C# implementation of the Rapid Automatic Keyword Extraction</h2>
<p><a href="https://github.com/benmcevoy/Rake">https://github.com/benmcevoy/Rake</a></p>
<h2>fromskyblue/Keywords-Extraction: Zhen Yang-Keywords Extraction</h2>
<p><a href="https://github.com/fromskyblue/Keywords-Extraction">https://github.com/fromskyblue/Keywords-Extraction</a></p>
<p>Keyword extraction by entropy difference between the intrinsic and extrinsic mode
We strive to propose a new metric to evaluate and rank the relevance of words in a text. The method uses the Shannon’s entropy difference between the intrinsic and extrinsic mode, which refers to the fact that relevant words significantly reflect the author’s writing intention, i.e., their occurrences are modulated by the author’s purpose, while the irrelevant words are distributed randomly in the text. By using The Origin of Species by Charles Darwin as a representative text sample, the performance of our detector is demonstrated and compared to previous proposals. Since a reference text ‘‘corpus’’ is all of an author’s writings, books, papers, etc. his collected works is not needed. Our approach is especially suitable for single documents of which there is no a priori information available.</p>
<h2>GomesNayagam/keyword-extraction-single-document: keyword extraction from single document, algorithm from this paper <a href="http://ymatsuo.com/papers/ijait04.pdf">http://ymatsuo.com/papers/ijait04.pdf</a></h2>
<p><a href="https://github.com/GomesNayagam/keyword-extraction-single-document">https://github.com/GomesNayagam/keyword-extraction-single-document</a></p>
<h2>ruiyuanxu/MizumotoKeywordExtraction: A keyword extration tool built for Data Structure &amp; Algorithm course.</h2>
<p><a href="https://github.com/ruiyuanxu/MizumotoKeywordExtraction">https://github.com/ruiyuanxu/MizumotoKeywordExtraction</a></p>
<p>C#</p>
<h2>ASH1998/Keyword-extraction: Keyword Extraction for PDFs</h2>
<p><a href="https://github.com/ASH1998/Keyword-extraction">https://github.com/ASH1998/Keyword-extraction</a></p>
<p>Dependencies:</p>
<ul>
<li>PyPDF2</li>
<li>sklearn</li>
<li>pandas</li>
</ul>
<p>Algorithm used</p>
<p>LDA : Linear Discriminant Analysis A classifier with a linear decision boundary, generated by fitting class conditional densities to the data and using Bayes’ rule. The model fits a Gaussian density to each class, assuming that all classes share the same covariance matrix. The fitted model can also be used to reduce the dimensionality of the input by projecting it to the most discriminative directions.</p>
<p>NMF : Non-Negative Matrix Factorization (NMF) - Find two non-negative matrices (W, H) whose product approximates the non- negative matrix X. This factorization can be used for example for dimensionality reduction, source separation or topic extraction.</p>
<h2>WuLC/KeywordExtraction: Implementation of algorithm in keyword extraction,including TextRank,TF-IDF and the combination of both</h2>
<p><a href="https://github.com/WuLC/KeywordExtraction">https://github.com/WuLC/KeywordExtraction</a></p>
<p>Implementation of serveral algorithms for keyword extraction,including TextRank,TF-IDF,TextRank along with TFTF-IDF.Cutting words and filtering stop words are relied on HanLP</p>
<h2>hankcs/HanLP: Han Language Processing</h2>
<p><a href="https://github.com/hankcs/HanLP">https://github.com/hankcs/HanLP</a></p>
<p>Natural Language Processing for the next decade. Tokenization, Part-of-Speech Tagging, Named Entity Recognition, Syntactic &amp; Semantic Dependency Parsing, Document Classification</p>
<p>The multilingual NLP library for researchers and companies, built on TensorFlow 2.0, for advancing state-of-the-art deep learning techniques in both academia and industry. HanLP was designed from day one to be efficient, user friendly and extendable. It comes with pretrained models for various human languages including English, Chinese and many others.</p>
<h2>Linguistic/rake: A Java library for Rapid Automatic Keyword Extraction (RAKE) 🍂</h2>
<p><a href="https://github.com/Linguistic/rake">https://github.com/Linguistic/rake</a></p>
<p>RAKE is an algorithm for extracting keywords (technically phrases, but I don’t question scientific literature) from a document that have a high relevance or importance to the contents of the document.</p>
<h2>sing1ee/textrank-java: a simple implementation of textrank algorithm for nlp keywords extraction</h2>
<p><a href="https://github.com/sing1ee/textrank-java">https://github.com/sing1ee/textrank-java</a></p>
<h2>ibatra/BERT-Keyword-Extractor: Deep Keyphrase Extraction using BERT</h2>
<p><a href="https://github.com/ibatra/BERT-Keyword-Extractor">https://github.com/ibatra/BERT-Keyword-Extractor</a></p>
<h2>aespresso/chinese_nlp_tutorial_clustering_keywords_extraction: 中文自然语言处理聚类与关键词提取教程</h2>
<p><a href="https://github.com/aespresso/chinese_nlp_tutorial_clustering_keywords_extraction">https://github.com/aespresso/chinese_nlp_tutorial_clustering_keywords_extraction</a></p>
<h2>BastinFlorian/Keywords_extraction_with_GOW: Graph of words (Networkx) and keywords extraction (Ktruss, Kcore, DivRank, BestCoverage)</h2>
<p><a href="https://github.com/BastinFlorian/Keywords_extraction_with_GOW">https://github.com/BastinFlorian/Keywords_extraction_with_GOW</a></p>
<ul>
<li>First we present an example of the methods used to extract keywords (see Graph of words and keywords extraction.ipynb and K-truss_code_example.ipynb)</li>
<li>Then we give a code to compute the k_core and obtain the graphs of directories of files or all files in directories containing sub-directories (see K_core_corpus.py)</li>
<li>We also give an implementation of the K-truss algorithm (see K-truss_code.py)</li>
<li>We make a time analysis to see the evolution of some words through time, in order to detect events related to them.</li>
</ul>
<h2>RHKeng/ShenCeCup: A competition on DataCastle which is about text keyword extraction ! Rank 6 / 622 !</h2>
<p><a href="https://github.com/RHKeng/ShenCeCup">https://github.com/RHKeng/ShenCeCup</a></p>
<p>A competition on DataCastle which is about text keyword extraction! Rank 6/622!</p>
<p>&quot; Shence Cup&quot; 2018 College Algorithm Masters is a single-player competition that can only be soloed by college students. Shence Data provides the titles and texts of about 100,000 news articles, of which 1,000 articles have corresponding annotation data. There are no more than 5 keywords for each article in the labeled data, and the keywords have appeared in the title or body of the article. According to the existing data, it is necessary to train a “keyword extraction” model to extract the keywords of articles without annotated data, and submit at most two keywords for each article.</p>
<p>Final ranking: 6/622</p>
<p>[…]</p>
<h3>5 Model selection</h3>
<p>Compare the effects of unsupervised models (tfidf/tfiwf, textRank, topic model LSI/LDA), and finally use tfidf as the basic model to select the keyword candidate set.</p>
<h4>5.1 The tfidf</h4>
<p>tfidf (term frequency-inverse document frequency) algorithm is a statistical method used to evaluate the importance of a word to a document set or a document in a corpus. The importance of a word increases in proportion to the number of times it appears in the document, but at the same time it decreases in inverse proportion to the frequency of its appearance in the corpus.</p>
<p>TF (term frequency) is the number of times a word appears in the article, TF (term frequency) = the number of times a word appears in the article / the total number of words in the article; IDF (inverse document frequency) is the frequency of the word , IDF reverse document frequency=log (total number of documents in the corpus/(total number of documents containing the word+1)), if a word is more common, then its denominator is larger, and the IDF value is smaller.</p>
<h4>5.2 Tfiwf</h4>
<p>TF remains unchanged, IWF is the sum of the word frequency of all words in the document/the word frequency</p>
<h4>5.3 Pagerank (listed here only to lead to the following textrank)</h4>
<p>need to know which webpages are linked to webpage A, that is, first get webpage A’s access to the chain, and then calculate webpage A’s PR by voting for webpage A from the access chain value. This design can ensure the achievement of such an effect: when some high-quality webpages point to webpage A, then the PR value of webpage A will increase because of these high-quality votes, and webpage A is pointed to by fewer webpages or by some When a web page with a lower PR value points to, the PR value of A will not be very large, which can reasonably reflect the quality level of a web page. Vi represents a certain webpage, Vj represents a webpage linked to Vi (that is, the in-link of Vi), S(Vi) represents the PR value of the webpage Vi, In(Vi) represents the collection of all in-<abbr title="[object Object]">links</abbr> of the webpage Vi, Out(Vj) Represents the number of web pages Vj linked to other web pages, and d represents the damping coefficient, which is used to overcome the inherent defects of the part after “d *” in this formula: if there is only a summation part, then the formula will not be able to handle The PR value of the web pages that enter the chain, because at this time, according to the formula, the PR value of these web pages is 0, but the actual situation is not like this, so a damping coefficient is added to ensure that each web page has a PR value greater than 0. According to the experimental results, with a damping coefficient of 0.85, the PR value can be converged to a stable value after about 100 iterations. When the damping coefficient is close to 1, the number of iterations required will increase abruptly and the sorting will be unstable. The score in front of S(Vj) in the formula refers to the PR value of Vj that should be divided equally among all the webpages pointed to by Vj, so that it can be regarded as dividing one’s votes among the webpages that one <abbr title="[object Object]">links</abbr> to.</p>
<h4>5.4 textrank</h4>
<p>is a graph-based sorting algorithm for text, which can realize keyword extraction only by using the information of a single document itself, without relying on a corpus. (Calling the interface of jieba ) Wji refers to the similarity between the two sentences of Vi and Vj. Edit distance and cosine similarity can be used. When textrank is applied to keyword extraction, it is different from automatic abstract extraction: 1) The association between words has no weight, that is, Wji is 1; 2) Each word is not linked to all words in the document, but through Set a fixed-length sliding window format, with <abbr title="[object Object]">links</abbr> between words in the window.</p>
<h4>5.5 The Topic Model</h4>
<p>topic model believes that there is no direct connection between words and documents, and that they should be connected by a dimension, which is the topic. The topic model is an automatic analysis of each document, counting the words in the document, and judging which topics the current document contains and the proportion of each topic based on the statistical information. A topic model is a generative model. Each word in an article is obtained through a process of “select a topic with a certain probability, and select a word from this topic with a certain probability”; topic models are commonly used The methods are LSI (LSA) and LDA, where LSI uses SVD (Singular Value Decomposition) for brute force cracking, while LDA uses Bayesian methods to fit distribution information. Through the LSA or LDA algorithm, you can get the distribution of the document to the topic and the distribution of the topic to the word. The distribution of the word to the topic can be obtained according to the topic to the word distribution (Bayesian method), and then through this distribution and the document to the topic distribution Calculate the similarity between the document and the word, and select the word list with high similarity as the key word of the document.</p>
<h4>5.5.1 LSA</h4>
<p>Latent Semantic Analysis (LSA), also called Latent Semantic Indexing, LSI. It is a commonly used simple topic model. LSA is a way to get the text topic based on the singular value decomposition (SVD) method. Umk represents the distribution matrix of documents to topics, and the transposition of Vnk represents the distribution matrix of topics to words. LSA uses SVD to express words and documents more essentially, and maps them to low-dimensional spaces. While limited use of text semantic information, LSA greatly reduces the cost of calculation and improves the quality of analysis. However, the computational complexity is very high, and the feature space dimension is large, and the computational efficiency is very low. When a new document enters the existing feature space, the entire space needs to be retrained to obtain the distribution information of the newly added document. In addition, there are problems of insensitivity to frequency distribution and weak physical interpretation.</p>
<h4>5.5.2 pLSA</h4>
<p>has been improved on the basis of LSA, by using the EM algorithm to fit the distribution information instead of using SVD for brute force cracking.</p>
<p>In PLSA, the bag-of-words model is also used (the bag-of-words model refers to a document. We only consider whether a word appears, regardless of the order in which it appears. On the contrary, n-gram considers the order in which the words appear). And the documents are independently exchangeable, and the words in the same document are also independently exchangeable. In PLSA, we will extract a topic word with a fixed probability, then find the corresponding word distribution according to the extracted topic word, and then extract a vocabulary according to the word distribution.</p>
<h4>5.5.3 LDA</h4>
<p>LDA is based on PLSA and adds two Dirichlet prior distributions to topic distribution and word distribution. In PLSA, both topic distribution and word distribution are uniquely determined. However, in LDA, topic distribution and word distribution are uncertain. The authors of LDA adopt Bayesian thinking and believe that they should obey a distribution. Both topic distribution and word distribution are polynomial distributions, because polynomial distributions Dirichlet distribution and Dirichlet distribution are conjugate structures. In LDA, topic distribution and word distribution use Dirichlet distribution as their conjugate prior distribution.</p>
<p>In LDA, there is no fixed optimal solution for the number of topics. When training the model, the number of topics needs to be set in advance, and the trainer needs to manually adjust the parameters according to the training results, and then optimize the number of topics. We can find the posterior distribution according to the polynomial distribution and the prior distribution of the data, and then use this posterior distribution as the next prior distribution, and iteratively update. There are generally two solving methods, the first is based on Gibbs sampling algorithm, and the second is based on variational inference EM algorithm.</p>
<h2>XuMuK1/KeywordsExtraction: Project for courses NLA and Optimization in Sk. The goal is to learn how to test different techniques for extracting keywords from news.</h2>
<p><a href="https://github.com/XuMuK1/KeywordsExtraction">https://github.com/XuMuK1/KeywordsExtraction</a></p>
<h2>pozhidaevsa/ExtractionKeywords: Extract keywords from russian text</h2>
<p><a href="https://github.com/pozhidaevsa/ExtractionKeywords">https://github.com/pozhidaevsa/ExtractionKeywords</a></p>
<h2>csurfer/rake-nltk: Python implementation of the Rapid Automatic Keyword Extraction algorithm using NLTK.</h2>
<p><a href="https://github.com/csurfer/rake-nltk">https://github.com/csurfer/rake-nltk</a></p>
<p>RAKE short for Rapid Automatic Keyword Extraction algorithm, is a domain independent keyword extraction algorithm which tries to determine key phrases in a body of text by analyzing the frequency of word appearance and its co-occurance with other words in the text.</p>
<h2>AidenHuen/SMP-Keyword-Extraction: CSDN博客的关键词提取算法，融合TF，IDF，词性，位置等多特征。该项目用于参加2017 SMP用户画像测评，排名第四,在验证集中精度为59.9%，在最终集中精度为58.7%。模型并未使用机器学习的方法，具有较强的泛化能力。</h2>
<p><a href="https://github.com/AidenHuen/SMP-Keyword-Extraction">https://github.com/AidenHuen/SMP-Keyword-Extraction</a></p>
<p>About CSDN blog keyword extraction algorithm, fusion TF, IDF, part of speech, location and other features.</p>
<p>This project was used to participate in the 2017 SMP user portrait evaluation, ranking fourth, with an accuracy of 59.9% in the verification set and 58.7% in the final set.
The model does not use machine learning methods and has strong generalization capabilities.</p>
<h2>bguvenc/keyword_extraction: Keyword extraction with Word2Vec</h2>
<p><a href="https://github.com/bguvenc/keyword_extraction">https://github.com/bguvenc/keyword_extraction</a></p>
<p>Keyword extraction method by using Word2Vec and Pagerank algorithms
The most common representation of distributional semantics is called one-hot representation in which dimensionality is equal to vocabulary’s cardinality. Elements of this vector space representation consist of 0’s and 1’s. However, this representation has some disadvantages. For example, in these representations, it is difficult to make deductions about word similarity. Due to high dimensionality, they can also cause overfitting. Moreover, it is computationally expensive.</p>
<p>Word embeddings are designed to capture attributional similarities between vocabulary items. Words that appear in similar contexts should be close to each other in the projected vector space. This means that grouping of words in a vector space must share same semantic properties. In word embeddings, Latent Semantic Analysis (LSA) uses a counting base dimensionality reduction method. Word2Vec is created as an alternative. Its low dimensionality can help to reduce computational complexity. Also compared with distributional semantics methods, it causes less overfitting. Word2Vec can also detect analogies between words.</p>
<p>Our model takes Word2Vec representations of words in a vector space. While we construct the Word2Vec model, we decide a threshold of counts of words because words that appear only once or twice in a large corpus are probably not unusual for the model, and there is not enough data to make any meaningful training on those words. A reasonable value for minimum counts changes between 0-100, and it depends on the size of corpora. Another critical parameter for Word2Vec model is the dimension of the vectors. This value changes between 100 and 400. Dimensions larger than 400 require more training but leads to more accurate models. I used Google News corpora which provided by Google which consist of 3 million word vectors. I did not remove stop words or infrequent words because these algorithms use windows and to find vector representations. So I need the nearby words to find vector representations.</p>
<p>The second step of this algorithm is to find PageRank value of each word. PageRank algorithm works with random walk. The original PageRank algorithm takes internet pages as a node. In our model PageRank algorithm takes Word2Vec representations of words. The cosine distance is used to calculate edge weights between nodes. TextRank algorithm uses a similar method. While TextRank chooses the bag of word representations of words and a different similarity measure in finding edge weights, in this algorithm I used the Word2Vec representations and the cosine similarity. After PageRank values of words are found, we can get words which have the highest PageRank values. Finally, these words can be seen as a keyword of a text.</p>
<h2>gaussic/tf-idf-keyword: Keyword extraction based on TF-IDF on specific corpus. 基于特定语料库的TF-IDF的中文关键词提取</h2>
<p><a href="https://github.com/gaussic/tf-idf-keyword">https://github.com/gaussic/tf-idf-keyword</a></p>
<p>Chinese keyword extraction</p>
<p>requirements based on TF-IDF.</p>
<h2>naushadzaman/keyword-extraction-from-tweets: keyword extraction from tweets using python</h2>
<p><a href="https://github.com/naushadzaman/keyword-extraction-from-tweets">https://github.com/naushadzaman/keyword-extraction-from-tweets</a></p>
<p>keyword extraction from tweets using python</p>
<p>In this module, we use Pattern tools to do POS tagging/Phrase extraction of tweets. The usual POS tagging/chunking tools do not work well for free form texts like tweets, so we needed to use a tool that is designed and trained for twitter/tweets. From Pattern tool output, we extract phrases as entities. You can decide to use on NP (Noun Phrase), but our default is to use NP (Noun Phrase) and ADJP (Adjective Phrase). With this tool, you can also extract hashtags, usernames, urls from the tweet.</p>
<h2>vgrabovets/multi_rake: Multilingual Rapid Automatic Keyword Extraction (RAKE) for Python</h2>
<p><a href="https://github.com/vgrabovets/multi_rake">https://github.com/vgrabovets/multi_rake</a></p>
<p>Multilingual Rapid Automatic Keyword Extraction (RAKE) for Python</p>
<p>Features</p>
<ul>
<li>Automatic keyword extraction from text written in any language</li>
<li>No need to know language of text beforehand</li>
<li>No need to have list of stopwords</li>
<li>26 languages are currently available, for the rest - stopwords are generated from provided text</li>
<li>Just configure rake, plug in text and get keywords (see implementation details)</li>
</ul>
<h2>lovit/soykeyword: Python library for keyword extraction</h2>
<p><a href="https://github.com/lovit/soykeyword">https://github.com/lovit/soykeyword</a></p>
<p>Python library for Keyword Extraction</p>
<p>Python library for keyword/association extraction. Keywords and related words extracted from by Lovit (Hyunjoong) and Hunsik Shin</p>
<p>soykeyword are defined as follows. Keywords in a set of documents are words of good quality (discriminative power) that can distinguish them from other sets of documents, and words (high coverage) that can describe them well. Words with a low frequency are more likely to appear in only one set, so they have a high level of discrimination, but weak explanation. The proposed two algorithms select words that have high explanatory and distinguishing power as keywords. An associative word defines a keyword that separates a set of documents with and without a reference word from an associative word. This also means that the word with high co-occurrence. Choose words with high co-occurrence and good explanation.</p>
<h2>tarwn/bookmark_analysis: Exploration of text analysis for automatic bookmarking/keyword extraction</h2>
<p><a href="https://github.com/tarwn/bookmark_analysis">https://github.com/tarwn/bookmark_analysis</a></p>
<p>Automated Keyword Extraction – TF-IDF, RAKE, and TextRank</p>
<p>After initially playing around with text processing in my prior post, I added an additional algorithm and cleaned up the logic to make it easier to perform test runs and reuse later. I tweaked the RAKE algorithm implementation and added TextRank into the mix, with full sample code and <abbr title="[object Object]">links</abbr> to sources available. I’m also using a read-through cache of the unprocessed and processed files so I can see the content and tweak the cleanse logic.</p>
<p>Context: The ultimate goal is to build a script that could process through 6 years of my bookmarked reading and extract out keywords, so I could do some trend analysis on how my reading has changed over time and maybe later build a supervised model with that data to analyze new online posts and produce a “worth my time or not” score.</p>
<h2>Parsely/serpextract: Easy extraction of keywords and engines from search engine results pages (SERPs).</h2>
<p><a href="https://github.com/Parsely/serpextract">https://github.com/Parsely/serpextract</a></p>
<p>serpextract provides easy extraction of keywords from search engine results pages (SERPs).</p>
<p>This module is possible in large part to the very hard work of the Piwik team. Specifically, we make extensive use of their list of search engines.</p>
<h2>singularity014/Keyword-Extraction-Bidirectional-LSTM: Deep learning LSTM + BERT based approach for labelling a corpus with keywords, then training a model to extract keywords.</h2>
<p><a href="https://github.com/singularity014/Keyword-Extraction-Bidirectional-LSTM">https://github.com/singularity014/Keyword-Extraction-Bidirectional-LSTM</a></p>
<p>Deep learning Bi-LSTM based approach for labelling a corpus with keywords, then training a model to extract keywords.</p>
<p>Article was late published in pprints.</p>
<h2>pemagrg1/Hindi-POS-Tagging-and-Keyword-Extraction: Hindi POS Tags and keywords using TNT model. Created Date: 28 Sept 2018</h2>
<p><a href="https://github.com/pemagrg1/Hindi-POS-Tagging-and-Keyword-Extraction">https://github.com/pemagrg1/Hindi-POS-Tagging-and-Keyword-Extraction</a></p>
<p>Part of speech plays a very major role in NLP task as it is important to know how a word is used in every sentences. POS tagging is used mostly for Keyword Extractions, phrase extractions, Named Entity Recognition, etc. Before going further on POS tagging, I am assuming that you all know about part of speech as we all have studied grammar during school. Didn’t we? But anyways let me give a brief explanation on it!</p>
<p>There are eight main Parts of Speech: Nouns(naming word), Pronouns(replaces a noun), Adjectives(describing word), Verbs(action word), Adverbs(describes a verb), Prepositions(shows relationships), Conjunctions(joining word) and Interjections(Expressive word). Most of it are further divided into sub-parts. Noun is divided into Proper Nouns, Common Nouns, Concrete Nouns etc.</p>
<p>Reminds you of school days?? Okay now lets start with Hindi Part of Speech Tagging.</p>
<p>Hindi Part of Speech Tagging is something that people are still doing research on as we have various techniques and libraries available for English Text and rarely for Hindi Text. <a href="https://pybliometrics.readthedocs.io/en/stable/index.html">1</a> Manish and Pushpak researched on Hindi POS using a simple HMM based POS tagger with accuracy of 93.12%. while <a href="https://github.com/OrganicIrradiation/scholarly">2</a>Nisheeth Joshi, Hemant Darbari and Iti Mathur also researched on Hindi POS using Hidden Markov Model with frequency count of two tags seen together in the corpus divided by the frequency count of the previous tag seen independently in the corpus. <a href="https://virtualenv.pypa.io/en/stable/">3</a> S Phani Kumar Gadde, Meher Vijay Yeleti used CRF based tagger and Brants TnT (Brants, 2000), a HMM based tagger for hindi POS Tag where they got an acccuracy of 94.21%.</p>
<h2>abner-wong/textrank: keyword extraction and summarization for Chinese text by TextRank</h2>
<p><a href="https://github.com/abner-wong/textrank">https://github.com/abner-wong/textrank</a></p>
<p>Based on the TextRank algorithm, the keyword extraction and summarization tasks of Chinese text are realized, and the core calculation code remains consistent with the paper.</p>
<h2>yongzhuo/Macropodus: 自然语言处理工具Macropodus，基于Albert+BiLSTM+CRF深度学习网络架构，中文分词，词性标注，命名实体识别，新词发现，关键词，文本摘要，文本相似度，科学计算器，中文数字阿拉伯数字(罗马数字)转换，中文繁简转换，拼音转换。tookit(tool) of NLP，CWS(chinese word segnment)，POS(Part-Of-Speech Tagging)，NER(name entity recognition)，Find(new words discovery)，Keyword(keyword extraction)，Summarize(text summarization)，Sim(text similarity)，Calculate(scientific calculator)，Chi2num(chinese number to arabic number)</h2>
<p><a href="https://github.com/yongzhuo/Macropodus">https://github.com/yongzhuo/Macropodus</a></p>
<p>Macropodus is a natural language processing toolkit trained on large-scale Chinese corpus based on the Albert+BiLSTM+CRF network architecture. Common NLP functions such as Chinese word segmentation, part-of-speech tagging, named entity recognition, keyword extraction, text summarization, new word discovery, text similarity, calculator, number conversion, pinyin conversion, traditional and simplified conversion will be provided.</p>
<h2>kanjirz50/rake-ja: Rapid Automatic Keyword Extraction algorithm for Japanese</h2>
<p><a href="https://github.com/kanjirz50/rake-ja">https://github.com/kanjirz50/rake-ja</a></p>
<p>Rapid Automatic Keyword Extraction algorithm for Japanese.</p>
<p>This module builds on rake-nltk.</p>
<h2>killa1218/CopyRNN-Keyword-Extraction</h2>
<p><a href="https://github.com/killa1218/CopyRNN-Keyword-Extraction">https://github.com/killa1218/CopyRNN-Keyword-Extraction</a></p>
<p>This is an implementation of Deep Keyphrase Generation based on CopyNet.</p>
<p>One training dataset (KP20k), five testing datasets (KP20k, Inspec, NUS, SemEval, Krapivin) and one pre-trained model are provided.</p>
<p>Note that the model is trained on scientific papers (abstract and keyword) in Computer Science domain, so it’s expected to work well only for CS papers.</p>
<h2>CodePothunter/keywordExtract_zh: A Chinese key terminology extraction tool for MOOC.</h2>
<p><a href="https://github.com/CodePothunter/keywordExtract_zh">https://github.com/CodePothunter/keywordExtract_zh</a></p>
<p>A Chinese key terminology extraction tool for MOOC. This tool needs to rely on the latest version of jieba for word segmentation. When using, put the entire folder in the working directory and call it as a toolkit. At present, in addition to supporting the extraction of key terms, it can also generate a summary of the lecture notes.</p>
<h2>pemagrg1/Nepali-POS-Tagging-and-Keyword-Extraction: Extract part of speech for Nepali words using TNT model. Created Date: 12 October 2018</h2>
<p><a href="https://github.com/pemagrg1/Nepali-POS-Tagging-and-Keyword-Extraction">https://github.com/pemagrg1/Nepali-POS-Tagging-and-Keyword-Extraction</a></p>
<p>Nepali is the language spoken by the people of Nepal. Nepali is actually written with the Devanagari alphabet and is an Indo-Aryan Language. The Devanagari script, which is generally known as Nagari, is written from left to right. The order of the letters made up of vowels and consonants is known as the “varnamala” which means the “garland of flowers.” In the Unicode Conventional, the Devanagari is constituted in three blocks. U+0900–U+097F comprises the Devanagari, U+1CD0–U+1CFF comprises the Devanagari Extended, and U+A8E0–U+A8FF comprises the Vedic Extension.</p>
<p>The paper, “Structure of Nepali Grammar” by Bal Krishna Bal has an awesome explanation on the grammar of Nepali <a href="https://pybliometrics.readthedocs.io/en/stable/index.html">1</a> where he explains how each part of speech is used in Nepali. Asmita (Student of Bal Krishna Bal) has also done her degree project under the guidance of Bal Krishna Bal on “Part of Speech Tagger for Nepali Text using SVM” where she got an accuracy of 88% <a href="https://github.com/OrganicIrradiation/scholarly">2</a>. Tej Bahadur Shahi,Tank Nath Dhamala, and Bikash Balami also published a paper on “Support Vector Machines based Part of Speech Tagging for Nepali Text” where they got an accuracy of 90% on TNT and 90% on SVM, using 80000 training data size<a href="https://virtualenv.pypa.io/en/stable/">3</a>.</p>
<p>Nepali and Hindi are quite similar as they both follow the Devanagari script.</p>

  </head>
  <body>

    <h1>Full Text Search Engines</h1>
<p>index.rst
<a href="https://xapian.org/docs/">https://xapian.org/docs/</a></p>
<p>.net - Indexing .PDF, .XLS, .DOC, .PPT using <a href="http://Lucene.NET">Lucene.NET</a> - Stack Overflow
<a href="https://stackoverflow.com/questions/4905271/indexing-pdf-xls-doc-ppt-using-lucene-net">https://stackoverflow.com/questions/4905271/indexing-pdf-xls-doc-ppt-using-lucene-net</a></p>
<p>Welcome to the <a href="http://Lucene.Net">Lucene.Net</a> website! | Apache <a href="http://Lucene.NET">Lucene.NET</a> 4.8.0
<a href="https://lucenenet.apache.org/">https://lucenenet.apache.org/</a></p>
<p>How to compile and use Xapian on Windows with C# - CodeProject
<a href="https://www.codeproject.com/Articles/71593/How-to-compile-and-use-Xapian-on-Windows-with-C">https://www.codeproject.com/Articles/71593/How-to-compile-and-use-Xapian-on-Windows-with-C</a></p>
<h1>Google Scholar</h1>
<p>You want BibTeX data, citations, etc. from Google.</p>
<p>[Edit: see <a href="#google-and-the-publishers">Google and the Publishers</a> section below for a very probable cause of the Scholar RECAPTCHA woes.]</p>
<p>Let’s not be squeamish about it: in exchange, Google wants your <em>soul</em>. Or your money, but in the case of Google Scholar, only your <em>soul</em> will do: lots of effort has been expended by Google in the last 1-2 years to <strong>block everyone that’s not provably a human using a modern browser <em>manually</em></strong>. And even than, you’re limited to only so much use of Scholar before you’re supposed to go back to basic Search, which at least can soak you in ads.</p>
<p>Sounds opinionated? Well, it’s “<em>follow the money</em>” as usual: if you <em>assume</em> Google is interested in <strong>human activity only</strong> – or more specifically stated: Google is <strong>only interested in humans who can click on ads</strong> – then <em>all</em> behavioural changes of the Google Scholar site over the recent months/years are <em>reasonable</em>:</p>
<ul>
<li>kill/thwart any robot activity on the site (heck, they could only be crawling, and <em>we, the Google</em> are the only ones who should be doing <em>that</em>!)</li>
<li>kill/thwart any old browsers: that’s humans with browsers/machines which will probably break on all those fancy modern commercial websites anyway, while using an outdated browser also clearly marks you as <em>having no purchase mandate or purchase budget</em>: you’re either a worker bee deep inside corporate firewalls or you’re not, ah, sufficiently pecuniary advanced to purchase something modern, with a recent operating system and ditto browser. That’s near zero buyer’s potential right there. Hence, we’re not interested. Bye.</li>
<li>kill/thwart any human that’s potentially wiping ads using filtering proxies (e.g. <a href="https://www.privoxy.org/">privoxy</a>) and such: you might be tech savvy, but we are <em>savvier</em>: if your HTTP request signature doesn’t look like it’s coming from a vanilla Chrome/Safari/FireFox/Edge browser, you’re probably not worth our while either. You get a few answers to show you we mean well, but nothing to generous.
<ul>
<li>when you ‘log in’ into your Google account while using Scholar, emperical data hints that you get more responses before you’re hit with a “not-a-robot?” query by your friends at Google.</li>
</ul>
</li>
<li>don’t give out many responses per unit of time: that sounds like crawling or heavy use: that should be monetized and while it isn’t, we’re going to send you through captcha hoops.</li>
</ul>
<p>The nett effect is that <strong>any embedded browser</strong> is dead in the water unless you make some serious effort to make it not appear so. The corrolary of this, by the way, is that a Google Scholar session inside an <code>\&lt;iframe&gt;</code> is a <strong>not-happening</strong> situation either: I have yet to find out exactly what metrics Google is inspecting to detect embedded browsers, but it certainly looks at the <code>User-Agent</code> and possibly at traffic, for it’s rather <em>uncanny</em> how good Google has become at detecting these things…</p>
<p>This translates to the Qiqqa Sniffer being a, ah, ‘<em>challenge</em>’ to make it work again in 2020 A.D.: one must make it look like it’s the genuine Chrome browser and no hanky panky happenin’, or you get toasted with CAPTCHA/robot checks and 503/429 HTTP error reponses, i.e. <em>no results what-so-ever</em> until you return the next day and try again.</p>
<p>Meanwhile, Google also seems to have added a VPN exit node blacklist of some sort as using a VPN to perform Google Scholar searches doesn’t seem to help: it was rather <em>worse</em> than Scholar-ing from the private node. Having had a look at <code>scholarly</code> (below) which uses the <code>tor</code> network as a randomizing VPN/proxy rig might fly better for a while, but I don’t know how long Google will keep up appearances regarding <code>tor</code> and disadvantaged web users from beyond the Great Firewall and elsewhere: in the end, they’re in it for the money. My opinion here: when / as-long-as the <code>tor</code> road works, heck, let’s do it!</p>
<h2>Google and the Publishers</h2>
<p>Found via the README of the project <a href="https://github.com/edsu/etudier"><code>edsu/etudier</code>: “Extract a citation network from Google Scholar”</a>:</p>
<blockquote>
<p>If you are wondering why it uses a non-headless browser it’s because <a href="https://www.quora.com/Are-there-technological-or-logistical-challenges-that-explain-why-Google-does-not-have-an-official-API-for-Google-Scholar">Google is quite protective of this data</a> and routinely will ask you to solve a captcha (identifying street signs, cars, etc in photos). étudier will allow you to complete these tasks when they occur and then will continue on its way collecting data.</p>
</blockquote>
<p><strong>Follow the money</strong>: following the link in the README above, Quora says:</p>
<blockquote>
<p>Aaron Tay, academic librarian who has studied, blogged and presented on Google scholar</p>
<p>Updated August 11, 2016</p>
<p>I’ve read or heard someone say that Google Scholar is given privileged access to crawl Publisher,aggregator (often enhanced with subject heading and controlled vocab) and none-free abstract and indexing sites like Elsevier and Thomson Reuters’s Scopus and Web of Science respectively.</p>
<p>Obviously the latter two wouldn’t be so wild about Google Scholar offering a API that would expose all their content to anyone since they sell access to such metadata.</p>
<p>Currently you only get such content (relatively rare) from GS if you are in the specific institution IP range that has subscriptions. (Also If your institution is already a subscriber to such services such as Web of Science or Scopus, you library could usually with some work allow you access directly via the specific resource API!.)</p>
<p>Even publishers like Wiley that are usually happy for their metadata to be freely available might not like the idea of a Google Scholar API. The reason is unlike Google, Google Scholar actually has access to the full text as well (which they sell)… If the API exposes that…</p>
<p>There are of course technical solutions if Google wants the API enough, but why would they make the effort?</p>
<p>As already mentioned Libraries do pay for things like Web of Science and Scopus and these services do provide APIs, so do consult a librarian if you have such access.</p>
<p>Also Web Scale discovery services that libraries pay for such as Summon, Ebsco discovery service, Primo etc do have APIs and they come closest to duplicating a (less comprehensive version) Google Scholar API</p>
<p>Another poor substitute to a Google Scholar API, is the Crossref Metadata Search. It’s not as comprehensive as Google Scholar but most major publishers do deposit their metadata.</p>
<hr>
<p>Tom Griffin, works at IEEE</p>
<p>Answered July 15, 2013</p>
<p>Google doesn’t have an API for Scholar likely for the same reason they don’t have an API for web search - it would get overwhelmed by applications creating aggregation platforms (and running continuous queries) versus applications that just run on-demand, user-initiated lookups (like Mendeley linking out to Google Scholar).</p>
<p>Couple this with the fact that Scholar is a philanthropic and they make no money off of it - there certainly isn’t the pressing need for an API.</p>
<p>There are, however, some openly available scrapers that work as an API. Of course, they only work well if they’re tuned to the current structure of Scholar search results. One such example</p>
<p><a href="https://www.icir.org/christian/scholar.html">A Parser for Google Scholar</a></p>
<p>The other thing to note is that Microsoft Academic Search does offer an API. You need to request a key, but other than that, it provides full programatic access to what the application returns using the web interface.</p>
<p><a href="https://www.microsoft.com/en-us/research/project/academic/articles/sign-academic-knowledge-api/">Microsoft Academic Search API</a></p>
</blockquote>
<h2>Analysis Notes</h2>
<ul>
<li>
<p>at least <em>some</em> of the Python repositories concerning themselves with Google Scholar crawling are using the python module <a href="https://pypi.org/project/scholarly/"><code>scholarly</code></a> under the hood.</p>
<p>Upon closer inspection of <a href="https://github.com/scholarly-python-package/scholarly">the source code</a>, that one appears to circumvent the Google Scholar restrictions by using a few tricks – see also <a href="https://github.com/scholarly-python-package/scholarly/blob/master/scholarly/_navigator.py#L82"><code>scholarly/_navigator.py</code></a>:</p>
<ul>
<li>
<p>using the <code>tor</code> <strong>proxy</strong> as a randomizing proxy, if available locally.</p>
<p>When a CAPTCHA from Google is detected, <a href="https://github.com/scholarly-python-package/scholarly/blob/master/scholarly/_navigator.py#L113">the tor proxy is refreshed</a> so our next (re)try would exit on a different tor network node.</p>
</li>
<li>
<p>sending <a href="https://github.com/scholarly-python-package/scholarly/blob/master/scholarly/_navigator.py#L90">a randomized <code>User-Agent</code></a> to thwart Google’s same-user detection heuristics. The UserAgent is randomly picked from a sane set using <a href="https://pypi.org/project/fake-useragent/">the Python module <code>fake_useragent</code></a>, which uses real-world User-Agent strings from [<a href="http://useragentstring.com">useragentstring.com</a>] – see also <a href="https://github.com/hellysmile/fake-useragent">its source code at github</a>.</p>
</li>
<li>
<p><a href="https://github.com/scholarly-python-package/scholarly/blob/master/scholarly/_navigator.py#L91">randomizing the GoogleID in the cookie that is sent along</a> with the search query.</p>
</li>
</ul>
</li>
</ul>
<hr>
<h2>jkeirstead/scholar: Analyse citation data from Google Scholar</h2>
<p><a href="https://github.com/jkeirstead/scholar">https://github.com/jkeirstead/scholar</a></p>
<p>The scholar R package provides functions to extract citation data from Google Scholar. In addition to retrieving basic information about a single scholar, the package also allows you to compare multiple scholars and predict future h-index values.</p>
<h3>Basic features</h3>
<p>Individual scholars are referenced by a unique character string, which can be found by searching for an author and inspecting the resulting scholar homepage. For example, the profile of physicist Richard Feynman is located at <a href="http://scholar.google.com/citations?user=B7vSqZsAAAAJ">http://scholar.google.com/citations?user=B7vSqZsAAAAJ</a> and so his unique id is B7vSqZsAAAAJ.</p>
<h3>Analysis Notes</h3>
<ul>
<li>
<p>Does some work to carry google cookies – see <a href="https://github.com/jkeirstead/scholar/blob/master/R/utils.R"><code>/R/utils.R</code></a> and <a href="https://github.com/jkeirstead/scholar/blob/master/R/scholar.r"><code>/R/scholar.r</code></a></p>
</li>
<li>
<p>Does not do any randomization or other Google Scholar thwarting.</p>
</li>
<li>
<p>However, it <em>does</em> detect Google HTTP response code 429:</p>
<pre class="language-R"><code class="language-R">else if (httr::status_code(resp) == 429) {
  stop(&quot;Response code 429. Google is rate limiting you for making too many requests too quickly.&quot;)
}
</code></pre>
</li>
</ul>
<h2>venthur/gscholar: Query Google Scholar with Python</h2>
<p><a href="https://github.com/venthur/gscholar">https://github.com/venthur/gscholar</a></p>
<h3>Using <code>gscholar</code> as a command line tool</h3>
<p><code>gscholar</code> provides a command line tool, to use it, just call <code>gscholar</code> like:</p>
<pre class="language-sh"><code class="language-sh">$ gscholar &quot;albert einstein&quot;
</code></pre>
<p>or</p>
<pre class="language-sh"><code class="language-sh">$ python3 -m gscholar &quot;albert einstein&quot;
</code></pre>
<p>Getting more results:</p>
<pre class="language-sh"><code class="language-sh">$ gscholar --all &quot;some author or title&quot;
</code></pre>
<p>Same as above but returns up to 10 bibtex items. (Use with caution Google will assume you’re a bot an ban you’re IP temporarily)</p>
<p>Querying using a pdf:</p>
<pre class="language-sh"><code class="language-sh">$ gscholar /path/to/pdf
</code></pre>
<p>Will read the pdf to generate a Google Scholar query. It uses this query to show the first bibtex result as above.</p>
<p>Renaming a pdf:</p>
<pre class="language-sh"><code class="language-sh">$ gscholar --rename /path/to/pdf
</code></pre>
<p>Will do the same as above but asks you if it should rename the file according to the bibtex result. You have to answer with “y”, default answer is no.</p>
<h3>Analysis Notes</h3>
<p>Nothing fancy. Does use <a href="https://github.com/venthur/gscholar/blob/master/gscholar/gscholar.py#L64">Google Scholar cookie</a> to request BibTeX (<a href="https://github.com/venthur/gscholar/blob/master/gscholar/gscholar.py#L34">or other format</a>).</p>
<h2>ckreibich/scholar.py: A parser for Google Scholar, written in Python</h2>
<p><a href="https://github.com/ckreibich/scholar.py">https://github.com/ckreibich/scholar.py</a></p>
<p><a href="http://scholar.py">scholar.py</a> is a Python module that implements a querier and parser for Google Scholar’s output. Its classes can be used independently, but it can also be invoked as a command-line tool.</p>
<p>The script used to live at <a href="http://icir.org/christian/scholar.html">http://icir.org/christian/scholar.html</a>, and I’ve moved it here so I can more easily manage the various patches and suggestions I’m receiving for <a href="http://scholar.py">scholar.py</a>.</p>
<h3>Analysis Notes</h3>
<p>No fancy stuff. Is aware of Scholar quirks but has no smart circumventions.</p>
<p>Does have <a href="https://github.com/ckreibich/scholar.py/blob/master/scholar.py">a nice list of query options</a> for Scholar though.</p>
<p>Has 61 open issues at the time of writing and 44 pull requests. For example, there’s the dreaded <a href="https://github.com/ckreibich/scholar.py/issues/106">HTTP Error 503: Service Unavailable</a> we’ve encountered so often ourselves.</p>
<p>Might be worth to merge several of those and mix in the <code>scholarly</code> library’s smart circumvention tactics to make this a viable tool in 2020 A.D.</p>
<h2>WittmannF/sort-google-scholar: Sorting Google Scholar search results based on the number of citations</h2>
<p><a href="https://github.com/WittmannF/sort-google-scholar">https://github.com/WittmannF/sort-google-scholar</a></p>
<p>This Python code ranks publications data from Google Scholar by the number of citations. It is useful for finding relevant papers in a specific field.</p>
<p>The data acquired from Google Scholar is Title, Citations, Links and Rank. A new columns with the number of citations per year is also included. The example of the code will look for the top 100 papers related to the keyword, and rank them by the number of citations. This keyword can eiter be included in the command line terminal ($python <a href="http://sortgs.py">sortgs.py</a> --kw ‘my keyword’) or edited in the original file. As output, a .csv file will be returned with the name of the chosen keyword ranked by the number of citations.</p>
<p><strong>GOOGLE COLAB</strong>: Try running the code using Google Colab! No install requirements! Limitations: Can’t handle robot checking, so use it carefully.</p>
<p>Handling robot checking with Selenium and Chrome browser: You might be asked to manually solve the first captcha for retrieving the content of the pages.</p>
<h3>Analysis Notes</h3>
<p>Nice, but like most of the others: no circumvention techniques. Uses Selenium to kickstart your Chrome browser so you can answer the Google CAPTCHAs, but that’s it.</p>
<h2>beloglazov/zotero-scholar-citations: Zotero plugin for auto-fetching numbers of citations from Google Scholar</h2>
<p><a href="https://github.com/beloglazov/zotero-scholar-citations">https://github.com/beloglazov/zotero-scholar-citations</a></p>
<p>This is an add-on for Zotero, a research source management tool. The add-on automatically fetches numbers of citations of your Zotero items from Google Scholar and makes it possible to sort your items by the citations. Moreover, it allows batch updating the citations, as they may change over time.</p>
<p>When updating multiple citations in a batch, it may happen that citation queries are blocked by Google Scholar for multiple automated requests. If a blockage happens, the add-on opens a browser window and directs it to <a href="http://scholar.google.com/">http://scholar.google.com/</a>, where you should see a Captcha displayed by Google Scholar, which you need to enter to get unblocked and then re-try updating the citations. It may happen that Google Scholar displays a message like the following “We’re sorry… but your computer or network may be sending automated queries. To protect our users, we can’t process your request right now.” In that case, the only solution is to wait for a while until Google unblocks you.</p>
<h3>Analysis Notes</h3>
<p>That stuff <a href="https://github.com/beloglazov/zotero-scholar-citations/blob/master/chrome/content/scripts/zoteroscholarcitations.js#L173">happens here</a>.</p>
<h2>lintool/scholar-scraper: Scrapes citation statistics from Google Scholar</h2>
<p><a href="https://github.com/lintool/scholar-scraper">https://github.com/lintool/scholar-scraper</a></p>
<p>I wrote this simple utility to scrape citation statistics of researcher profiles on Google Scholar, using it as an opportunity to learn node.js. I began with a list of information retrieval researchers, but have since expanded to include a separate list of researchers in human-computer interaction. The results are here.</p>
<p><strong>Editorial note</strong>: This list contains only researchers who have a Google Scholar profile; names were identified by snowball sampling and various other ad hoc techniques. If you wish to see a name added, please email me or send a pull request. I will endeavor to periodically run the crawl to gather updated statistics. Of course, scholarly achievement is only partially measured by citation counts, which are known to be flawed in many ways. Evaluations of scholars should include comprehensive examination of their research contributions.</p>
<h3>Analysis Notes</h3>
<p>Basic Scholar access, nothing fancy. Done <a href="https://github.com/lintool/scholar-scraper/blob/master/scrape.js#L12">here</a>.</p>
<h2>jimmytidey/bibnet-google-scholar-scraper</h2>
<p><a href="https://github.com/jimmytidey/bibnet-google-scholar-scraper">https://github.com/jimmytidey/bibnet-google-scholar-scraper</a></p>
<h3>Google and rate limiting</h3>
<p>This software should be used in compliance with Google’s rules. Much as Zotero uses Google Scholar’s results pages to populate it’s metadata fields, this seems like a reasonable use of their service.</p>
<p>There is a keys.js where you can provide cookie details, so that you are querying Google as a logged in user. I don’t think this adds any particular advantage.</p>
<h2>dnlcrl/PyScholar: A ‘supervised’ parser for Google Scholar</h2>
<p><a href="https://github.com/dnlcrl/PyScholar">https://github.com/dnlcrl/PyScholar</a></p>
<p>A “supervised” parser for Google Scholar, written in Python.</p>
<p>PyScholar is a command line tool written in python that implements a querier and parser for Google Scholar’s output. This project is inspired by <a href="http://scholar.py">scholar.py</a>, in fact there is a lot of code from that project, the main difference is that <a href="http://scholar.py">scholar.py</a> makes use of the urllib modules, thus, so no javascript, and given that people at big G don’t like you to scrape their search results, when the server responses the “I’m not a robot” page, you simply get no output from <a href="http://scholar.py">scholar.py</a>, for a long time. Instead PyScholar makes use of selenium webdriver giving the ability to see what’s going on and in case the “I’m not a robot” shows up you can simply pass the challenge manually and let the scraper continue his job.</p>
<p>Also there are some other new features I inclulded from my <a href="http://scholar.py">scholar.py</a> fork, that are: json exporting of the reults, “starting result” option, and the potential ability to get an unlimited number results, even if it seems that results are limited on server-side to approximately one thousand.</p>
<h3>Analysis Notes</h3>
<p>Hmmmm… Last work was done 5 years ago, but at least this sounds like something. It doesn’t have <code>scholarly</code>’s twists, but it does have the ‘pop up Chrome via Selenium so user can do the captcha thing’ approach at least.</p>
<p>Interesting. Should be tested…</p>
<h2>edsu/etudier: Extract a citation network from Google Scholar</h2>
<p><a href="https://github.com/edsu/etudier">https://github.com/edsu/etudier</a></p>
<p>étudier is a small Python program that uses Selenium and requests-html to drive a non-headless browser to collect a citation graph around a particular Google Scholar citation or set of search results. The resulting network is written out as a Gephi file and a D3 visualization using networkx. The D3 visualization could use some work, so if you add style to it please submit a pull request.</p>
<p>If you are wondering why it uses a non-headless browser it’s because <a href="https://www.quora.com/Are-there-technological-or-logistical-challenges-that-explain-why-Google-does-not-have-an-official-API-for-Google-Scholar">Google is quite protective of this data</a> and routinely will ask you to solve a captcha (identifying street signs, cars, etc in photos). étudier will allow you to complete these tasks when they occur and then will continue on its way collecting data.</p>
<h3>Analysis notes</h3>
<p><strong>Follow the money</strong>: following the link in the README above, Quora says:</p>
<blockquote>
<p>Aaron Tay, academic librarian who has studied, blogged and presented on Google scholar</p>
<p>Updated August 11, 2016</p>
<p>I’ve read or heard someone say that Google Scholar is given privileged access to crawl Publisher,aggregator (often enhanced with subject heading and controlled vocab) and none-free abstract and indexing sites like Elsevier and Thomson Reuters’s Scopus and Web of Science respectively.</p>
<p>Obviously the latter two wouldn’t be so wild about Google Scholar offering a API that would expose all their content to anyone since they sell access to such metadata.</p>
<p>Currently you only get such content (relatively rare) from GS if you are in the specific institution IP range that has subscriptions. (Also If your institution is already a subscriber to such services such as Web of Science or Scopus, you library could usually with some work allow you access directly via the specific resource API!.)</p>
<p>Even publishers like Wiley that are usually happy for their metadata to be freely available might not like the idea of a Google Scholar API. The reason is unlike Google, Google Scholar actually has access to the full text as well (which they sell)… If the API exposes that…</p>
<p>There are of course technical solutions if Google wants the API enough, but why would they make the effort?</p>
<p>As already mentioned Libraries do pay for things like Web of Science and Scopus and these services do provide APIs, so do consult a librarian if you have such access.</p>
<p>Also Web Scale discovery services that libraries pay for such as Summon, Ebsco discovery service, Primo etc do have APIs and they come closest to duplicating a (less comprehensive version) Google Scholar API</p>
<p>Another poor substitute to a Google Scholar API, is the Crossref Metadata Search. It’s not as comprehensive as Google Scholar but most major publishers do deposit their metadata.</p>
<hr>
<p>Tom Griffin, works at IEEE</p>
<p>Answered July 15, 2013</p>
<p>Google doesn’t have an API for Scholar likely for the same reason they don’t have an API for web search - it would get overwhelmed by applications creating aggregation platforms (and running continuous queries) versus applications that just run on-demand, user-initiated lookups (like Mendeley linking out to Google Scholar).</p>
<p>Couple this with the fact that Scholar is a philanthropic and they make no money off of it - there certainly isn’t the pressing need for an API.</p>
<p>There are, however, some openly available scrapers that work as an API. Of course, they only work well if they’re tuned to the current structure of Scholar search results. One such example</p>
<p><a href="https://www.icir.org/christian/scholar.html">A Parser for Google Scholar</a></p>
<p>The other thing to note is that Microsoft Academic Search does offer an API. You need to request a key, but other than that, it provides full programatic access to what the application returns using the web interface.</p>
<p><a href="https://www.microsoft.com/en-us/research/project/academic/articles/sign-academic-knowledge-api/">Microsoft Academic Search API</a></p>
</blockquote>
<h2>VT-CHCI/google-scholar: nodejs module for searching google scholar</h2>
<p><a href="https://github.com/VT-CHCI/google-scholar">https://github.com/VT-CHCI/google-scholar</a></p>
<p>nodejs module for searching google scholar</p>
<h3>Analysis Notes</h3>
<p>Has <a href="https://github.com/VT-CHCI/google-scholar/blob/master/index.js#L7">request rate limiting and some HTTP error response detection logic</a>, but no circumventions.</p>
<p>Done in JS, so might be handier to start with than some Python code if we want to roll it into Qiqqa.</p>
<h2>linhung0319/google-scholar-crawler: A crawler to crawl google scholar search page</h2>
<p><a href="https://github.com/linhung0319/google-scholar-crawler">https://github.com/linhung0319/google-scholar-crawler</a></p>
<p>這是我練習寫的一個爬取Google Scholar Search Page的網路爬蟲程式</p>
<p>zhè shì wǒ liànxí xiě de yīgè pá qǔ Google Scholar Search Page de wǎng lù páchóng chéngshì</p>
<p>This is a web crawler program that I practice to write to crawl Google Scholar Search Page</p>
<p>How to Use</p>
<ol>
<li>
<p>Go to Google Scholar Search and enter the keywords you want to find, arrive at the first page of the Search Page, and copy the URL of this page</p>
</li>
<li>
<p>Enter google_crawler.py and put the copied URL into start_url, start_url =‘URL’</p>
</li>
<li>
<p>p_key puts the keywords you want to find, n_key puts the keywords you don’t want to find in the Search Page, the title and content of each cell, if it contains the words in p_key, Crawler will tend to grab this paper.</p>
<p>In the page, if the title and content of each cell contain the words in n_key, Crawler will tend to ignore this paper.</p>
<p>In the above picture, because I want to find the paper related to sound, not to find the paper related to optics, so p_key Put sound-related words in the n_key and optical-related words in the n_key</p>
</li>
<li>
<p>Set page = number, you can set the Google Search Page to be crawled. Setting too many pages will induce Google’s robot check</p>
</li>
<li>
<p>Start execution The program runs google_crawler.py in Terminal.</p>
</li>
</ol>
<p><code>$ python google_crawler.py</code> will save the captured data (‘title’,‘year’,‘url’,…) in result.pickle and then run csvNdownload in <a href="http://terminal.py">terminal.py</a></p>
<p><code>$ python csvNdownload.py</code> Convert the data to a CSV file, save it in a CSV folder, download <abbr title="[object Object]">links</abbr> with Tag (PDF, HTML) to PDF files, and save them separately into PDF, HTML folder</p>
<h3>Google Robot Check</h3>
<p>Google Search Page will be anti-crawling Detection. If the speed of downloading or viewing web pages is too fast, he will suspect that you are a robot and ban your IP address.
The simplest method currently in mind is to use a VPN. When it is considered a robot, use it.</p>
<p>VPN immediately changes its IP address. Now there are many free VPNs on the Internet that can be downloaded.</p>
<p>If a message appears when running Crawler</p>
<p>__findPages - Can not find the pages link in the start URL!!</p>
<p>__findPages - 1. Google robot check might ban you from crawling!!</p>
<p>__findPages - 2. You might not crawl the page of google scholar</p>
<p>The solution is to use VPN and change IP</p>
<h2>cute-jumper/gscholar-bibtex: Retrieve BibTeX entries from Google Scholar, ACM Digital Library, IEEE Xplore and DBLP</h2>
<p><a href="https://github.com/cute-jumper/gscholar-bibtex">https://github.com/cute-jumper/gscholar-bibtex</a></p>
<h3>Analysis Notes</h3>
<p>Looks like a pretty vanilla scraper. Has extras for other sites though:</p>
<blockquote>
<p>Retrieve BibTeX entries from Google Scholar, ACM Digital Library, IEEE Xplore and DBLP by your query. All in Emacs Lisp!</p>
<p><em>UPDATE</em>: ACM Digital Library, IEEE Xplore, and DBLP are now supported though the package name doesn’t suggest that.</p>
<p><a href="https://github.com/cute-jumper/gscholar-bibtex/blob/master/gscholar-bibtex.el">https://github.com/cute-jumper/gscholar-bibtex/blob/master/gscholar-bibtex.el</a></p>
</blockquote>
<h2>alberto-martin/googlescholar: Code to extract bibliographic data from Google Scholar</h2>
<p><a href="https://github.com/alberto-martin/googlescholar">https://github.com/alberto-martin/googlescholar</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>
<p>Uses Selenium driver approach</p>
</li>
<li>
<p>Uses <code>scrapy</code> package</p>
</li>
<li>
<p>From the README:</p>
<p>Be aware that if too many queries are carried out in a short period of time, Google Scholar will ask you to solve one or several CAPTCHAs, or will directly block you. The script will detect when Google Scholar requests a CAPTCHA, and will pause if this happens. The user must solve the CAPTCHA manually. When the browser resumes displaying search results, the user can resume the process by clicking enter in the terminal window. This script cannot resume automatically after Google Scholar has blocked you for making too many queries.</p>
</li>
</ul>
<h2>leventsagun/scholar-bib-scraper: Get bibtex from saved Google Scholar articles</h2>
<p><a href="https://github.com/leventsagun/scholar-bib-scraper">https://github.com/leventsagun/scholar-bib-scraper</a></p>
<h3>Analysis Notes</h3>
<p>Another Selenium driver based tool.</p>
<p>From the README:</p>
<p>Little script to get BibTeX entries of Google Scholar articles that are saved in personal accounts (for some reason Google Scholar doesn’t have a bulk export option for all saved articles).</p>
<p>Requires manual login and possible reCAPTCHA solving at the beginning.</p>
<h2>supasorn/GoogleScholarCopyBibTeX: Copy BibTeX on Google Scholar Search page with a single click</h2>
<p><a href="https://github.com/supasorn/GoogleScholarCopyBibTeX">https://github.com/supasorn/GoogleScholarCopyBibTeX</a></p>
<p>A Chrome plugin that adds “Copy BibTeX” button to Google Scholar Search result. BibTex can be copied to your system’s clipboard with a single click. <a href="https://chrome.google.com/webstore/detail/google-scholar-bibtex/lpadjkikoegfojgbhapfmkanmpoejdia">https://chrome.google.com/webstore/detail/google-scholar-bibtex/lpadjkikoegfojgbhapfmkanmpoejdia</a></p>
<h2>maikelronnau/google_scholar_paper_finder: A engine that searches for papers on Google Scholar based on keywords extracted from a text.</h2>
<p><a href="https://github.com/maikelronnau/google_scholar_paper_finder">https://github.com/maikelronnau/google_scholar_paper_finder</a></p>
<h3>Analysis Notes</h3>
<p>Uses a locally modified <code>scholar</code> package. Pretty vanilla otherwise.</p>
<h2>ag-gipp/grespa: A tool to obtain and analyze data from Google Scholar</h2>
<p><a href="https://github.com/ag-gipp/grespa">https://github.com/ag-gipp/grespa</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>Uses <code>scrapy</code> package for Scholar access.</li>
<li>From the README:</li>
</ul>
<h4>GRESPA Scraper</h4>
<p>The spiders can be run locally (in the current shell) or using the <em>scrapyd</em> daemon. The following part describes the
local installation and configuration necessary to run the scrapy spiders.</p>
<h4>Dependencies</h4>
<p>Installation details are provided by the readme located in the projects root directory.</p>
<p>For the proxy connection a socks proxy (e.g. tor) can be used, together with a http proxy
to fire the actual requests against.</p>
<p>Recommended proxies:</p>
<ul>
<li>socks proxy: standard tor client</li>
<li>http proxy: <code>privoxy</code> or <code>polipo</code></li>
</ul>
<p>See <code>settings.py</code> for the appropriate http proxy port. If you do not want to use a proxy, you can disable the proxy
middleware in the scrapy settings.</p>
<h4>Configuration</h4>
<p>Environment variables (or crawler settings) are used to configure credentials like passwords or database connections.
The files <code>*.env-sample</code> contain all parameters that are currently used (with placeholders). To provide your values,
strip the suffix <code>-sample</code> from the files and fill in your values.
So the file <code>database.env</code> contains the correct postgres connection credentials. To actually use the values,
you can export the variables as <em>environment variables</em>.</p>
<h4>Tor Control</h4>
<p>The following config parameters are used to control the tor client using the built in class:</p>
<ul>
<li><code>TOR_CONTROL_PASSWORD=...</code></li>
</ul>
<h2>yufree/scifetch: webpage crawling tools for pubmed, google scholar and rss</h2>
<p><a href="https://github.com/yufree/scifetch">https://github.com/yufree/scifetch</a></p>
<h3>Analysis Notes</h3>
<p>Has two vanilla scrapers for Google Scholar and PubMed.</p>
<h2>pykong/PyperGrabber: Fetches PubMed article IDs (PMIDs) from email inbox, then crawls PubMed, Google Scholar and Sci-Hub for respective PDF files.</h2>
<p><a href="https://github.com/pykong/PyperGrabber">https://github.com/pykong/PyperGrabber</a></p>
<h3>PyperGrabber</h3>
<p>Fetches PubMed article IDs (PMIDs) from email inbox, then crawls <strong>PubMed</strong>, <strong>Google Scholar</strong> and <strong>Sci-Hub</strong> for respective PDF files.</p>
<p>PubMed can send you regular update on new articles matching your specified search criteria. PyperGrabber will automatically download thoe papers, saving you much time tracking on downloading those manually. When no PDF article is found PyperGrabber will save the PubMed abstract of the respective article to PDF. All files are named after PMID for convenience.</p>
<h4>NOTES:</h4>
<ul>
<li><em>Messy code ahead!</em></li>
<li>Program may halt without error message. The source of this bug is yet to be determined.</li>
<li>The web crawler function may be used to work with other sources of PMIDs then email (e.g. command line parameter  or file holding list of PMIDs)</li>
</ul>
<h2>pentas1150/google-scholar-keyword-crwaler: 구글 스칼라에서 논문 제목을 단어 단위로 쪼개어 단어 카운팅해주는 크롤러</h2>
<p><a href="https://github.com/pentas1150/google-scholar-keyword-crwaler">https://github.com/pentas1150/google-scholar-keyword-crwaler</a></p>
<h3>Translated README:</h3>
<p>I stopped due to the Google reCAPTCHA problem… Even with Beautifulsoup &amp; Selenium, it could not be solved well, so I am exploring another solution. It doesn’t show up again after a certain time. But if I turn it again, it blocks and it hurts.</p>
<h4>Brief explanation</h4>
<p>Graduate students will read a lot of thesis. I’m looking for papers on Google Scholar and I’m curious about recent research trends, but it’s hard to find one by one. So, by counting the words in the title of the paper by crawling, I created it to help understand the latest research trends. (We will continue to refine it.)</p>
<h3>Analysis Notes</h3>
<p>Uses <code>axios</code> npm package for URL querying Scholar, hence is pretty vanilla. JavaScript.</p>
<p>Scholar access code at <a href="https://github.com/pentas1150/google-scholar-keyword-crwaler/blob/master/crwal.js#L19">https://github.com/pentas1150/google-scholar-keyword-crwaler/blob/master/crwal.js#L19</a></p>
<h2>janosh/gatsby-source-google-scholar: Gatsby source plugin that pulls metadata for scientific publications from Google Scholar</h2>
<p><a href="https://github.com/janosh/gatsby-source-google-scholar">https://github.com/janosh/gatsby-source-google-scholar</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla scraper in JavaScript.</p>
<p>Has very clear and grokkable error messages: might be useful for that. <a href="https://github.com/janosh/gatsby-source-google-scholar/blob/master/scraper.js">https://github.com/janosh/gatsby-source-google-scholar/blob/master/scraper.js</a></p>
<h2>Nicozheng/GoogleScholarCrawler: search, format, and download paper form google scholar</h2>
<p><a href="https://github.com/Nicozheng/GoogleScholarCrawler">https://github.com/Nicozheng/GoogleScholarCrawler</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla scraper using Selenium driver and BeautifulSoup packages.</p>
<h2>zjuiuczy/Google-Scholar: cs411 project</h2>
<p><a href="https://github.com/zjuiuczy/Google-Scholar">https://github.com/zjuiuczy/Google-Scholar</a></p>
<h3>Analysis Notes</h3>
<p>Visualization project from local databases. <strong>Not a scraper!</strong></p>
<h2>fholstege/GoogleScholar_Research</h2>
<p><a href="https://github.com/fholstege/GoogleScholar_Research">https://github.com/fholstege/GoogleScholar_Research</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>Uses <code>scrapy</code> for Scholar access: <a href="https://github.com/fholstege/GoogleScholar_Research/blob/master/gscholar/spiders/gsspider.py">https://github.com/fholstege/GoogleScholar_Research/blob/master/gscholar/spiders/gsspider.py</a> &amp; <a href="https://github.com/fholstege/GoogleScholar_Research/blob/master/gscholar/gscholar_crawlprocess.py#L47">https://github.com/fholstege/GoogleScholar_Research/blob/master/gscholar/gscholar_crawlprocess.py#L47</a></li>
</ul>
<p>From the README:</p>
<h3>Retrieving data from Google Scholar for research</h3>
<p>(Currently in development)</p>
<p>This is repository is my attempt to make a tool that allows users to scrape data from profiles on GoogleScholar. This data will be put into a dataset that contains the following information:</p>
<ul>
<li>
<p>h-index - the h-index for the professor for all years</p>
</li>
<li>
<p>h5-index  - the h-index for the professor for the last five years</p>
</li>
<li>
<p>i10-index - the i10 index for the professor for all years</p>
</li>
<li>
<p>i10-5-index - the i10 index for the professor for the last five years</p>
</li>
<li>
<p>n_citations - the total number of citations</p>
</li>
<li>
<p>n5_citations  - the total number of citations for the last five years</p>
</li>
<li>
<p>institution - the institution of the profile user</p>
</li>
<li>
<p>name  - name of the profile user</p>
</li>
<li>
<p>url - link to the profile</p>
</li>
<li>
<p>field - using tags, we determine the field the profile is active in</p>
</li>
</ul>
<p>Users should be able to fill in their field of interest and the number of profiles they want to scrape. A first version of the scraper has already been used by students of Leiden and Oxford University.</p>
<h2>mattkearl/AdvancedSearchforGoogleScholar: Advanced Search for Google Scholar</h2>
<p><a href="https://github.com/mattkearl/AdvancedSearchforGoogleScholar">https://github.com/mattkearl/AdvancedSearchforGoogleScholar</a></p>
<p>From the README:</p>
<h3>An extension to help users expand their search queries on Google Scholar.</h3>
<p>The <strong>BEST</strong> advanced search for Google Scholar is finally here!</p>
<h4>What is Google Scholar Plus?</h4>
<p>Google Scholar Plus is an <strong>extension</strong> that helps users discover better search results. Where you can quickly explore related words that can narrow or broaden your search on Google Scholar.</p>
<p>Whether you are working on research, academic, or scholarly papers, Google Scholar Plus will help you explore words to narrow or broaden your search results – on the fly.  This easy to use extension will help college and university students create a better and more advanced searches for research and college papers.</p>
<p>Feeling stuck? Having a hard time coming up with the right search? Google Scholar Plus can also help by expanding your search by providing relevant search terms.</p>
<p>Google Scholar Plus can also help you discover articles similar to the search query you are currently using.</p>
<p>When you install Google Scholar Plus, Google Scholar will automatically update your related word options to customize your now advanced search query.</p>
<p>Google Scholar Plus was created and developed by university students and faculty FOR university students and faculty.</p>
<h2>hazelnutsgz/NaiveScholarMap: Interactive Visualization Of Google Scholar connection all past 20 years</h2>
<p><a href="https://github.com/hazelnutsgz/NaiveScholarMap">https://github.com/hazelnutsgz/NaiveScholarMap</a></p>
<h3>Analysis Notes</h3>
<p>Visualization tool.</p>
<p>From the README: “Google Scholar Connection visualized by echart”</p>
<h2>Robinlovelace/scholarsearch: Tiny R package that makes it easy to search for academic publications on Google Scholar from the command line</h2>
<p><a href="https://github.com/Robinlovelace/scholarsearch">https://github.com/Robinlovelace/scholarsearch</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla crawler in R</p>
<h2>TWRogers/google-scholar-export: Takes a Google Scholar profile URL and outputs an html snippet to add to your website.</h2>
<p><a href="https://github.com/TWRogers/google-scholar-export">https://github.com/TWRogers/google-scholar-export</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla scraper in Python.</p>
<p>From the README:</p>
<p><strong>google-scholar-export</strong> is a Python library for scraping Google scholar profiles to generate a HTML publication lists.</p>
<p>Currently, the profile can be scraped from either the Scholar user id, or the Scholar profile URL, resulting in a list
of the following:</p>
<ol>
<li>Publication title</li>
<li>Publication authors</li>
<li>Journal information (name, issue no., vol.)</li>
<li>Date</li>
<li>Url to the Scholar publication</li>
<li>The number of citations according to Scholar</li>
</ol>
<p>The resulting html is formatted like:</p>
<pre class="language-html"><code class="language-html"><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>p</span><span class="token punctuation">></span></span>Publications (<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>b</span><span class="token punctuation">></span></span>20<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>b</span><span class="token punctuation">></span></span>) last scraped for <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>a</span> <span class="token attr-name">href</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>https://scholar.google.co.uk/citations?user=JicYPdAAAAAJ&amp;hl=en<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>Geoffrey Hinton<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>a</span><span class="token punctuation">></span></span> on <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>b</span><span class="token punctuation">></span></span>2019-08-11<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>b</span><span class="token punctuation">></span></span> 
using <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>a</span> <span class="token attr-name">href</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>https://github.com/TWRogers/google-scholar-export<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>google-scholar-export<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>a</span><span class="token punctuation">></span></span>.<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>p</span><span class="token punctuation">></span></span>
<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>div</span> <span class="token attr-name">class</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>card<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>
    <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>div</span> <span class="token attr-name">class</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>card-publication<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>
        <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>div</span> <span class="token attr-name">class</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>card-body card-body-left<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>
            <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>h4</span><span class="token punctuation">></span></span><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>a</span> <span class="token attr-name">href</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>https://scholar.google.co.uk/citations?user=JicYPdAAAAAJ&amp;hl=en#d=gs_md_cita-d&amp;u=%2Fcitations%3Fview_op%3Dview_citation%26hl%3Den%26oe%3DASCII%26user%3DJicYPdAAAAAJ%26citation_for_view%3DJicYPdAAAAAJ%3AGFxP56DSvIMC<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>Learning internal representations by error-propagation<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>a</span><span class="token punctuation">></span></span><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>h4</span><span class="token punctuation">></span></span>
            <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>p</span><span class="token style-attr language-css"><span class="token attr-name"> <span class="token attr-name">style</span></span><span class="token punctuation">="</span><span class="token attr-value"><span class="token property">font-style</span><span class="token punctuation">:</span> italic<span class="token punctuation">;</span></span><span class="token punctuation">"</span></span><span class="token punctuation">></span></span>by DE Rumelhart, GE Hinton, RJ Williams<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>p</span><span class="token punctuation">></span></span>
            <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>p</span><span class="token punctuation">></span></span><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>b</span><span class="token punctuation">></span></span>Parallel Distributed Processing: Explorations in the Microstructure of …<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>b</span><span class="token punctuation">></span></span><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>p</span><span class="token punctuation">></span></span>
        <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>div</span><span class="token punctuation">></span></span>
    <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>div</span><span class="token punctuation">></span></span>
    <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>div</span> <span class="token attr-name">class</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>card-footer<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>
        <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>small</span> <span class="token attr-name">class</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>text-muted<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>Published in <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>b</span><span class="token punctuation">></span></span>1986<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>b</span><span class="token punctuation">></span></span> | 
        <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>a</span> <span class="token attr-name">href</span><span class="token attr-value"><span class="token punctuation">=</span><span class="token punctuation">"</span>https://scholar.google.co.uk/scholar?oi=bibs&amp;hl=en&amp;oe=ASCII&amp;cites=1374659557399191249,4574189560556662535,10453698013284960354,12541410141153091507,7476519782727404507,1722523513356915749,6822548856209813074,4464353390709992638,15344233312479649775<span class="token punctuation">"</span></span><span class="token punctuation">></span></span>Citations: <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span>b</span><span class="token punctuation">></span></span>62260<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>b</span><span class="token punctuation">></span></span><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>a</span><span class="token punctuation">></span></span><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>small</span><span class="token punctuation">></span></span>
    <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>div</span><span class="token punctuation">></span></span>
<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span>div</span><span class="token punctuation">></span></span>
...
</code></pre>
<p>And is primarily aimed at people using Bootstrap.</p>
<p>It is possible to modify the html for each publication by modifying <code>PAPER_TEMPLATE</code> in <code>./exporter/exporter.py</code></p>
<h2>Rationale</h2>
<p>Generating lists of publications for static websites is a pain. Google Scholar, popular amongst academics, is great at
tracking publications and citations. However, it does not have an API.</p>
<p>There are some other libraries:</p>
<ul>
<li><a href="https://github.com/dschreij/scholar_parser">dschreij/scholar_parser</a></li>
<li><a href="https://github.com/bborrel/google-scholar-profile-parser">bborrel/google-scholar-profile-parser</a></li>
</ul>
<p>However, both of these are php based, and not useful for static sites.</p>
<p>The purpose of this repository is to allow generation of static html code directly from your Google Scholar profile.
This code can be run manually, or at website build time to update the publications list.</p>
<p>Here is an example that utilises this library:
<a href="https://twrogers.github.io/projects.html#publications">twrogers.github.io/projects.html</a></p>
<h2>Ir1d/PKUScholar: A naive Google Scholar for PKU CS</h2>
<p><a href="https://github.com/Ir1d/PKUScholar">https://github.com/Ir1d/PKUScholar</a></p>
<h3>Analysis Notes</h3>
<p>Uses <code>scholarly</code> package: <a href="https://github.com/Ir1d/PKUScholar/blob/master/crawler/crawler.py">https://github.com/Ir1d/PKUScholar/blob/master/crawler/crawler.py</a></p>
<h2>leyiwang/nlp_research: The Research Spider for Anthology.</h2>
<p><a href="https://github.com/leyiwang/nlp_research">https://github.com/leyiwang/nlp_research</a></p>
<p>This toolkit can automatically grab the papers information by given keywords in title. You can set the search params: the conference, publication date and the keywords in title . Then it will automatically save these papers’ title, authors, download link, Google Scholar cited number and abstracts information in a Excel file.</p>
<h3>Analysis Notes</h3>
<p>Uses Selenium driver approach.</p>
<h2>tyiannak/pyScholar: Python Library to Analyse and Visualise Google Scholar Metadata</h2>
<p><a href="https://github.com/tyiannak/pyScholar">https://github.com/tyiannak/pyScholar</a></p>
<h3>Analysis Notes</h3>
<p>Uses <code>scholarly</code> package.</p>
<h2>lyn716/CitationsGenerator: for generating cite relation of articles in google scholar</h2>
<p><a href="https://github.com/lyn716/CitationsGenerator">https://github.com/lyn716/CitationsGenerator</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>uses SOCKS5 proxies, etc.: <a href="https://github.com/lyn716/CitationsGenerator/blob/master/crawl_tools/request_with_proxy.py">https://github.com/lyn716/CitationsGenerator/blob/master/crawl_tools/request_with_proxy.py</a></li>
<li>uses UserAgent spoofing: <a href="https://github.com/lyn716/CitationsGenerator/blob/master/crawl_tools/ua_pool.py">https://github.com/lyn716/CitationsGenerator/blob/master/crawl_tools/ua_pool.py</a></li>
<li>has code on board for Selenium driver, but I don’t see it used (yet).</li>
<li>Scholar access: <a href="https://github.com/lyn716/CitationsGenerator/blob/master/GoogleInfoGenerator.py">https://github.com/lyn716/CitationsGenerator/blob/master/GoogleInfoGenerator.py</a></li>
<li>Tor proxy check: <a href="https://github.com/lyn716/CitationsGenerator/blob/master/tor_test.py">https://github.com/lyn716/CitationsGenerator/blob/master/tor_test.py</a></li>
</ul>
<h2>alvinwan/webfscholar: Generate publications webpage from a google scholar</h2>
<p><a href="https://github.com/alvinwan/webfscholar">https://github.com/alvinwan/webfscholar</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>
<p>Vanilla crawler: <a href="https://github.com/alvinwan/webfscholar/blob/master/webfscholar/profile.py">https://github.com/alvinwan/webfscholar/blob/master/webfscholar/profile.py</a></p>
</li>
<li>
<p>But has some extra bits that may be of interest at the biTeX level. From the README:</p>
<h4>Why webfscholar</h4>
<p>The intermediate bibtex allows you to plug-and-play with other
auto-publication-webpage services. Furthermore, unlike most Google Scholar
unofficial APIs, this library:</p>
<ul>
<li>Uses information pulled directly from the Google Scholar profile page, as
opposed to un-configurable search results. This means <code>webfscholar</code> will
respect any custom titles or removed publications.</li>
<li>Supplants Google Scholar information using ArXiv.</li>
</ul>
</li>
</ul>
<h2>troore/scholar-spider: A spider to get researcher information, citations, etc. from academic libraries like IEEE digital library, google scholar, microsoft academic, etc.</h2>
<p><a href="https://github.com/troore/scholar-spider">https://github.com/troore/scholar-spider</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>Vanilla crawler</li>
<li>uses <a href="http://scholar.glgoo.org/scholar">http://scholar.glgoo.org/scholar</a> which redirects to Microsoft Bing these days instead (August 2020)</li>
<li><a href="https://github.com/troore/scholar-spider/blob/master/getcitation.py">https://github.com/troore/scholar-spider/blob/master/getcitation.py</a></li>
</ul>
<h2>miostudio/DawnScholar: A scholar search for The People who cannot access google scholar freely.</h2>
<p><a href="https://github.com/miostudio/DawnScholar">https://github.com/miostudio/DawnScholar</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>
<p>vanilla crawler: <a href="https://github.com/miostudio/DawnScholar/blob/master/gs.php">https://github.com/miostudio/DawnScholar/blob/master/gs.php</a></p>
</li>
<li>
<p>From the README:</p>
<p>For those who need scholar search in mainland China.</p>
<p>url：<a href="http://a.biomooc.com/">http://a.biomooc.com/</a></p>
<p>local: <a href="http://scholar.wjl.com/">http://scholar.wjl.com/</a></p>
</li>
</ul>
<h2>chrokh/lit: Command line tool for systematic literature reviews using Google Scholar</h2>
<p><a href="https://github.com/chrokh/lit">https://github.com/chrokh/lit</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>Uses Selenium driver together with JavaScript code: this is interesting as all the other Selenium driver users were coded in Python or PHP.</li>
<li>knows about and seems to attempt to handle RECAPTCHA, etc. Scholar nuisances: <a href="https://github.com/chrokh/lit/blob/master/src/scholar.js">https://github.com/chrokh/lit/blob/master/src/scholar.js</a></li>
<li>To be inspected further…</li>
</ul>
<h2>HTian1997/getarticle: getarticle is a package based on SciHub and Google Scholar that can download articles given DOI, website address or keywords.</h2>
<p><a href="https://github.com/HTian1997/getarticle">https://github.com/HTian1997/getarticle</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla downloader.</p>
<h2>fagnersutel/Google_Scholar: Google Scholar</h2>
<p><a href="https://github.com/fagnersutel/Google_Scholar">https://github.com/fagnersutel/Google_Scholar</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>Vanilla crawler</li>
<li>Check the queries: this one includes a call to fetch the <em>abstract</em> of a paper from Scholar, f.e.. <a href="https://github.com/fagnersutel/Google_Scholar/blob/master/google_scholar.R#L69">https://github.com/fagnersutel/Google_Scholar/blob/master/google_scholar.R#L69</a></li>
</ul>
<h2>tugcelmaci/GoogleScholarWebScraping: Google Scholar Web Scraping</h2>
<p><a href="https://github.com/tugcelmaci/GoogleScholarWebScraping">https://github.com/tugcelmaci/GoogleScholarWebScraping</a></p>
<h3>Analysis Notes</h3>
<p>multiple egotrip app. Vanilla.</p>
<h2>guzmonne/scholar: Google Scholar web scrapper</h2>
<p><a href="https://github.com/guzmonne/scholar">https://github.com/guzmonne/scholar</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla.</p>
<h2>arunhpatil/GoogleScholar: Revised GoogleScholar-API from fredrike</h2>
<p><a href="https://github.com/arunhpatil/GoogleScholar">https://github.com/arunhpatil/GoogleScholar</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>Vanilla scraper in PHP</li>
<li><a href="https://github.com/arunhpatil/GoogleScholar/blob/master/GoogleScholar.php#L16">https://github.com/arunhpatil/GoogleScholar/blob/master/GoogleScholar.php#L16</a></li>
</ul>
<h2>ChenZhongPu/GoogleScholar: This is an extension for PopClip to search in a China’s google scholar mirror site</h2>
<p><a href="https://github.com/ChenZhongPu/GoogleScholar">https://github.com/ChenZhongPu/GoogleScholar</a></p>
<h2>jiamings/scholar-bibtex-keys: Convert bibtex keys to Google scholar style: [first-author-last-name][year][title-first-word]</h2>
<p><a href="https://github.com/jiamings/scholar-bibtex-keys">https://github.com/jiamings/scholar-bibtex-keys</a></p>
<h2>lovit/google_scholar_citation_keywords: Google scholar citation keyword</h2>
<p><a href="https://github.com/lovit/google_scholar_citation_keywords">https://github.com/lovit/google_scholar_citation_keywords</a></p>
<h2>dtczhl/dtc-google-scholar-helper: Google Scholar Helper</h2>
<p><a href="https://github.com/dtczhl/dtc-google-scholar-helper">https://github.com/dtczhl/dtc-google-scholar-helper</a></p>
<h2>Andorreta/ScholarCrawler: Google Scholar Crawler</h2>
<p><a href="https://github.com/Andorreta/ScholarCrawler">https://github.com/Andorreta/ScholarCrawler</a></p>
<h2>jjsantanna/google_scholar_crawler: Google Scholar Crawler</h2>
<p><a href="https://github.com/jjsantanna/google_scholar_crawler">https://github.com/jjsantanna/google_scholar_crawler</a></p>
<h2>calebchiam/GoogleScholarScraper: Uses Python scholarly package to scrape relevant articles with given search terms, and then filters by title</h2>
<p><a href="https://github.com/calebchiam/GoogleScholarScraper">https://github.com/calebchiam/GoogleScholarScraper</a></p>
<h2>MJHutchinson/GoogleScholarWebscraping: Utility to scrape google scholar for citation data</h2>
<p><a href="https://github.com/MJHutchinson/GoogleScholarWebscraping">https://github.com/MJHutchinson/GoogleScholarWebscraping</a></p>
<h2>HilaryTraut/GoogleScholar_MetaAnalysis: A collection of simple scripts for retrieving citation information from a Google Scholar search.</h2>
<p><a href="https://github.com/HilaryTraut/GoogleScholar_MetaAnalysis">https://github.com/HilaryTraut/GoogleScholar_MetaAnalysis</a></p>
<h2>idchuem/googleScholar-ParsingBot</h2>
<p><a href="https://github.com/idchuem/googleScholar-ParsingBot">https://github.com/idchuem/googleScholar-ParsingBot</a></p>
<h2>gursidak/web_scrapping_googleScholar</h2>
<p><a href="https://github.com/gursidak/web_scrapping_googleScholar">https://github.com/gursidak/web_scrapping_googleScholar</a></p>
<h2>juicecwc/GoogleScholarCrawler</h2>
<p><a href="https://github.com/juicecwc/GoogleScholarCrawler">https://github.com/juicecwc/GoogleScholarCrawler</a></p>
<h2>foool/GoogleScholarBibTex: Batch get BibTeXs of papers collected in your Google Scholar library.</h2>
<p><a href="https://github.com/foool/GoogleScholarBibTex">https://github.com/foool/GoogleScholarBibTex</a></p>
<h2>michaelvdow/GoogleScholarScript</h2>
<p><a href="https://github.com/michaelvdow/GoogleScholarScript">https://github.com/michaelvdow/GoogleScholarScript</a></p>
<h2>Sharmelen/google_scholar: Extract data from google scholar</h2>
<p><a href="https://github.com/Sharmelen/google_scholar">https://github.com/Sharmelen/google_scholar</a></p>
<h2>maximusKarlson/google-scholar: Sort google scholar results by citations.</h2>
<p><a href="https://github.com/maximusKarlson/google-scholar">https://github.com/maximusKarlson/google-scholar</a></p>
<h2>Xotic-Knight/Google_Scholar</h2>
<p><a href="https://github.com/Xotic-Knight/Google_Scholar">https://github.com/Xotic-Knight/Google_Scholar</a></p>
<h2>smakonin/ScholarHacks: Scripts for hacking Google Scholar HTML pages.</h2>
<p><a href="https://github.com/smakonin/ScholarHacks">https://github.com/smakonin/ScholarHacks</a></p>
<h2>nivgold/SCholar: Nice tool to get useful authors information from google scholar. wraps the scholarly package.</h2>
<p><a href="https://github.com/nivgold/SCholar">https://github.com/nivgold/SCholar</a></p>
<h2>mehdi-user/ScholarChart: ScholarChart: a charting userscript for Google Scholar</h2>
<p><a href="https://github.com/mehdi-user/ScholarChart">https://github.com/mehdi-user/ScholarChart</a></p>
<h2>mehdi-user/ScholarChart: ScholarChart: a charting userscript for Google Scholar</h2>
<p><a href="https://github.com/mehdi-user/ScholarChart">https://github.com/mehdi-user/ScholarChart</a></p>
<h2>meander-why/konbini: crawler for google scholar</h2>
<p><a href="https://github.com/meander-why/konbini">https://github.com/meander-why/konbini</a></p>
<h3>Analysis Notes</h3>
<p>Uses its own vanilla crawler code. No error handling, nothing fancy.</p>
<h2>ViGeng/gs_spider: Google Scholar Spider</h2>
<p><a href="https://github.com/ViGeng/gs_spider">https://github.com/ViGeng/gs_spider</a></p>
<h3>Analysis Notes</h3>
<p>Uses Selenium driver based headless browser plus BeautifulSoup to fetch and crawl Scholar pages. Code is in <a href="https://github.com/ViGeng/gs_spider/blob/master/util/CitationGetter.py">https://github.com/ViGeng/gs_spider/blob/master/util/CitationGetter.py</a> + <a href="https://github.com/ViGeng/gs_spider/blob/master/util/Browser.py">https://github.com/ViGeng/gs_spider/blob/master/util/Browser.py</a> – nothing fancy beyond that.</p>
<p>Google Translation of README hints that they’re considering delays / timeouts, but I don’t see anything important implemented of that TODO list.</p>
<h2>sraashis/scholary: Scrap google scholar</h2>
<p><a href="https://github.com/sraashis/scholary">https://github.com/sraashis/scholary</a></p>
<h3>Analysis Notes</h3>
<p>Edit/Copy of scholarly. (Not forked)</p>
<h2>devteamepic/scholar-parser: Parser for google scholar</h2>
<p><a href="https://github.com/devteamepic/scholar-parser">https://github.com/devteamepic/scholar-parser</a></p>
<h3>Analysis Notes</h3>
<p>Edit/Copy of scholarly plus some extraction code, but nothing essential added to scholarly pops out in the initial inspection. (Not forked)</p>
<h2>charlesduan/scholar2tex: Convert Google Scholar cases to LaTeX</h2>
<p><a href="https://github.com/charlesduan/scholar2tex">https://github.com/charlesduan/scholar2tex</a></p>
<h3>Analysis Notes</h3>
<p>Processes downloaded / already fetched Scholar HTML pages.</p>
<p>From the README:</p>
<h4>scholar2tex</h4>
<p>Converts HTML for cases from Google Scholar into LaTeX. The resulting file is
formatted based on casemacs.sty, which will generate half-letter-size sheets
that can be compiled into a book.</p>
<p><strong>scholar2tex.rb</strong> - script that converts an HTML page of a Google Scholar case into
a LaTeX document.</p>
<h2>Bearzilasaur/ScholarScraper: Repository for a Google Scholar scraper for literature reviews.</h2>
<p><a href="https://github.com/Bearzilasaur/ScholarScraper">https://github.com/Bearzilasaur/ScholarScraper</a></p>
<h3>Analysis Notes</h3>
<p>While the requirements file lists <code>scholarly</code> as a dependency, it seems the code doesn’t use it (yet), but does vanilla URL queries and feeds the HTML to BeautifulSoup for data extraction.</p>
<p>Includes a Scopus scraper as well, but this one is vanilla as well and there’s mention of it in TODO so I wonder if the quick code inspection discovered a not-yet-working Scopus scraper?</p>
<h2>dilumb/scholarlyPull: Pull author details and papers from Google Scholar</h2>
<p><a href="https://github.com/dilumb/scholarlyPull">https://github.com/dilumb/scholarlyPull</a></p>
<h3>Analysis Notes</h3>
<p>From the README:</p>
<p>Pull author details and papers from Google Scholar. <strong>This tool is build on top of <code>scholarly</code>. Go through <code>scholarly-README.rst</code> for details on how to use scholarly for your need.</strong></p>
<p>That .rst file seems to be a copy of the <code>scholarly</code> README so nothing special.</p>
<h2>toolbuddy/ScholarJS: A parser for Google Scholar, written in JavaScript.</h2>
<p><a href="https://github.com/toolbuddy/ScholarJS">https://github.com/toolbuddy/ScholarJS</a></p>
<h3>Analysis Notes</h3>
<p>From the README:</p>
<p>I will always strive to add features that increase the power of this API, <strong>but I will never add features that intentionally try to work around the query limits imposed by Google Scholar. Please don’t ask me to add such features.</strong></p>
<h2>alegione/ScholarPlot: Shiny web tool for visualising and exporting google scholar data</h2>
<p><a href="https://github.com/alegione/ScholarPlot">https://github.com/alegione/ScholarPlot</a></p>
<h3>Analysis Notes</h3>
<p>Pretty useless as it’s for listing your own publications only. Let’s label this type of app ‘egotrip’ for I expect to run into more incantations of this sort of thing and I don’t want to spend time writing up analysis notes for each.</p>
<p>From the README:</p>
<p>The input is your Google Scholar ID. You can find this in your Google Scholar web address. If you go to your scholar profile, your individual ID can be found as part of the web address.</p>
<p>(Example URL)</p>
<p>In the above example, my user ID is highlighted (i.e. rW9T5f4AAAAJ).</p>
<p>The current primary output is a plot of papers per year and citations per year, a secondary output is a table of the publications of the author to date, ordered by ‘Paper Score’: A custom metric that aims to take into account impact factor of the journal and the number of citations per year of the manuscript itself. This can be helpful for applications that ask for you to provide your ‘top 10 papers’.</p>
<h2>tihbe/google_scholar_trend: A simple scientific paper based trend viewer using the number of results in Google Scholar.</h2>
<p><a href="https://github.com/tihbe/google_scholar_trend">https://github.com/tihbe/google_scholar_trend</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla URL querying.</p>
<h2>brunojus/google-scholar-crawler</h2>
<p><a href="https://github.com/brunojus/google-scholar-crawler">https://github.com/brunojus/google-scholar-crawler</a></p>
<h3>Analysis Notes</h3>
<p>Selenium driver based Scholar URL querying.</p>
<h2>siwalan/google-scholar-citation-scrapper: Simple scrapper for Google Scholar Data</h2>
<p><a href="https://github.com/siwalan/google-scholar-citation-scrapper">https://github.com/siwalan/google-scholar-citation-scrapper</a></p>
<h3>Analysis Notes</h3>
<p>egotrip style app. Vanilla code.</p>
<p>From the README:</p>
<p>This is a simple scrapper for Google Scholar Data, you can input a Google Scholar ID and it will return all the publications related to the said ID and citation data for the last 3 years. You can easily modify it to get data from only the last year, last five years, or all years the publication has been cited.</p>
<p>The program works by inputing a list of Google Scholar ID on the file called dosen.csv (you can change the file name, to add/remove scholars please just add or remove data in the row) and running all the ipynb cell. The ipynb will create a .xlsx file as the result containing all the publication from the said Google Scholar ID and the citations data for the last 3 years.</p>
<h2>lucgerrits/google-scholar-scraper: Basic Google Scholar scraper written in python.</h2>
<p><a href="https://github.com/lucgerrits/google-scholar-scraper">https://github.com/lucgerrits/google-scholar-scraper</a></p>
<h3>Analysis Notes</h3>
<p>Selenium driver based Scholar URL querying.</p>
<h2>madhawadias/google-scholar-profile-scraper: Scrape profiles of google scholar authors.</h2>
<p><a href="https://github.com/madhawadias/google-scholar-profile-scraper">https://github.com/madhawadias/google-scholar-profile-scraper</a></p>
<h3>Analysis Notes</h3>
<p>Uses <a href="https://github.com/scrapy/scrapy"><code>scrapy.http</code> package</a> for the Google Scholar scraping.</p>
<h2>gerryreilly/google_scholar_scrape: Sample code for scraping list of publication for a group of authors and saving in a csv file</h2>
<p><a href="https://github.com/gerryreilly/google_scholar_scrape">https://github.com/gerryreilly/google_scholar_scrape</a></p>
<h3>Analysis Notes</h3>
<p>Uses <code>scholarly</code>.</p>
<h2>SakuraX99/Crawler-For-Google-Scholar</h2>
<p><a href="https://github.com/SakuraX99/Crawler-For-Google-Scholar">https://github.com/SakuraX99/Crawler-For-Google-Scholar</a></p>
<h3>Analysis Notes</h3>
<p>Uses <code>scholarly</code> and <a href="https://pypi.org/project/free-proxy/"><code>fp</code> (FreeProxy)</a> to get the stuff. Clearly is a scratch project but might be handy to have a quick peek at it.</p>
<h2>WebGuruBoy/Python-google-scholar-scraping</h2>
<p><a href="https://github.com/WebGuruBoy/Python-google-scholar-scraping">https://github.com/WebGuruBoy/Python-google-scholar-scraping</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>
<p>uses Selenium driver based headless browser for Scholar URL querying</p>
</li>
<li>
<p>implements ‘adaptive request rate’ in <a href="https://github.com/WebGuruBoy/Python-google-scholar-scraping/blob/master/new_scholar.py#L69">https://github.com/WebGuruBoy/Python-google-scholar-scraping/blob/master/new_scholar.py#L69</a></p>
</li>
<li>
<p>From their <a href="https://github.com/WebGuruBoy/Python-google-scholar-scraping/blob/master/scholar.py">https://github.com/WebGuruBoy/Python-google-scholar-scraping/blob/master/scholar.py</a> ChangeLog:</p>
<p>2.11:  The Scholar site seems to have become more picky about the
number of results requested. The default of 20 in <a href="http://scholar.py">scholar.py</a>
could cause HTTP 503 responses. <a href="http://scholar.py">scholar.py</a> now doesn’t request
a maximum unless you provide it at the comment line. (For the
time being, you still cannot request more than 20 results.)</p>
</li>
</ul>
<p>Looks like (very) recent work done based on <code>scholar</code> package copy plus extras. Deserves a further peek beyond my initial scan.</p>
<h2>amychan331/google-scholar-scraper: Scraps scientific article data from Google Scholar and either create or update a node.</h2>
<p><a href="https://github.com/amychan331/google-scholar-scraper">https://github.com/amychan331/google-scholar-scraper</a></p>
<h3>Analysis Notes</h3>
<p><code>curl</code> + PHP based vanilla scraper.</p>
<h2>zhivou/google-scholar-helper: A simple gem to show information for 1 user from google scholar page</h2>
<p><a href="https://github.com/zhivou/google-scholar-helper">https://github.com/zhivou/google-scholar-helper</a></p>
<h3>Analysis Notes</h3>
<p>Ruby language tool, which uses the <a href="https://github.com/lostisland/faraday"><code>faraday</code> module</a> for Scholar access. From a very quick scan of that one (plus this codebase) the preliminary conclusion is: “yet another vanilla Scholar scraper”.</p>
<h2>liusida/Google-Scholar-Trends: Plot the trends of terminologies in Google Scholar over 20 years</h2>
<p><a href="https://github.com/liusida/Google-Scholar-Trends">https://github.com/liusida/Google-Scholar-Trends</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>
<p>uses a full set of faked headers (FireFox) to access the Scholar site: see <a href="https://github.com/liusida/Google-Scholar-Trends/blob/master/Google-Scholar-Trends.ipynb">https://github.com/liusida/Google-Scholar-Trends/blob/master/Google-Scholar-Trends.ipynb</a> near the top.</p>
</li>
<li>
<p>warns about Scholar: 2 secondd dealy between requests is advised in the README.</p>
</li>
</ul>
<h2>erkamozturk/Python-Google-Scholar</h2>
<h3>README</h3>
<p>Publications of faculty members at a university are usually published on university web pages. As an example, publications of SEHIR’s CS faculty members are published at their profile pages (e.g., see Ahmet Bulut’s publications at <a href="http://cs.sehir.edu.tr/en/profile/6/Ahmet-Bulut/">http://cs.sehir.edu.tr/en/profile/6/Ahmet-Bulut/</a>). However, searching for particular publications is not usually possible on such web pages.</p>
<p>In this project, you are going to develop a publication search engine (similar to Google Scholar) that will allow searching for publications of CS faculty members with some optional filters. Details regarding the requirements are as follows:
<a href="https://github.com/erkamozturk/Python-Google-Scholar">https://github.com/erkamozturk/Python-Google-Scholar</a></p>
<h3>Analysis Notes</h3>
<p>Don’t see nothing fancy. Vanilla crawl?</p>
<h2>mibot/Google-Scholar-Crawler</h2>
<p><a href="https://github.com/mibot/Google-Scholar-Crawler">https://github.com/mibot/Google-Scholar-Crawler</a></p>
<h3>Analysis Notes</h3>
<p>Has pretty basic Scholar scraper. Plus a CiteSeerX scraper.</p>
<p>Most work in here is about language detection, translation? (there’s an OAuth2-based google translate service being used?) and keyword analysis.</p>
<h2>chponte/google-scholar-search-engine</h2>
<p><a href="https://github.com/chponte/google-scholar-search-engine">https://github.com/chponte/google-scholar-search-engine</a></p>
<h3>Analysis Notes</h3>
<p>Extremely basic.</p>
<p>From the README:</p>
<p>This <em>extension</em> adds a search engine to Firefox.</p>
<h2>DaiJunyan/RutgersGoogleScholar</h2>
<p><a href="https://github.com/DaiJunyan/RutgersGoogleScholar">https://github.com/DaiJunyan/RutgersGoogleScholar</a></p>
<h3>Analysis Notes</h3>
<p>Looks like a rough copy &amp; edit work. Uses <code>scrapy</code> and the Selenium driver approach to access Scholar.</p>
<h2>JackXuRepo/Google-Scholar-Data-Scrapper: Developed a program, which reads and analyzes the contents of the Google Scholar Page of an author</h2>
<p><a href="https://github.com/JackXuRepo/Google-Scholar-Data-Scrapper">https://github.com/JackXuRepo/Google-Scholar-Data-Scrapper</a></p>
<h3>Analysis Notes</h3>
<p>Useless. Parses locally stored copies of HTML pages obtained from Google. Java.</p>
<h2>JohnZhang-source/download_google_scholar_alert: download papers in google scholar alert</h2>
<p><a href="https://github.com/JohnZhang-source/download_google_scholar_alert">https://github.com/JohnZhang-source/download_google_scholar_alert</a></p>
<h3>Analysis Notes</h3>
<p>Uses <a href="https://f.glgoo.top/scholar">https://f.glgoo.top/scholar</a> which (in my test) redirects to the Microsoft Bing search engine at the time of this writing (August 2020).</p>
<p>Uses User-Agent header and cookies. See <a href="https://github.com/JohnZhang-source/download_google_scholar_alert/blob/master/download%20paper%20in%20google%20scholar%20alert.py#L117">https://github.com/JohnZhang-source/download_google_scholar_alert/blob/master/download paper in google scholar alert.py#L117</a></p>
<h2>yokotatsuya/ExtractGoogleScholarCitations</h2>
<p>The matlab code to extract the list of publications of a personal author from Google Scholar Citations from only url (user id). Text Analytics toolbox is necessary.
<a href="https://github.com/yokotatsuya/ExtractGoogleScholarCitations">https://github.com/yokotatsuya/ExtractGoogleScholarCitations</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla access.</p>
<h2>paulazoo/google-scholar-h-index</h2>
<p>Some authors don’t have a Google Scholar stats page. This calculates an author’s h index based on citation and publication data from Google Scholar.
<a href="https://github.com/paulazoo/google-scholar-h-index">https://github.com/paulazoo/google-scholar-h-index</a></p>
<h3>Analysis Notes</h3>
<p>Selenium driver based.</p>
<h2>BAEM1N/google-scholar-crawler: with HYU or without HYU</h2>
<p><a href="https://github.com/BAEM1N/google-scholar-crawler">https://github.com/BAEM1N/google-scholar-crawler</a></p>
<h3>Analysis Notes</h3>
<p>With or without Selenium driver? Nothing fancy or new, anyway.</p>
<h2>Ngogabill/About-Google-Scholar</h2>
<p><a href="https://github.com/Ngogabill/About-Google-Scholar">https://github.com/Ngogabill/About-Google-Scholar</a></p>
<h3>Analysis Notes</h3>
<p>From the README:</p>
<p>This project consists of building a webpage similar to the original webpage of About google scholar . heres where u can find the orginal site.</p>
<h2>lorenzibex/Scrape-Google-Scholar: In this short python script you will see, how to extract/scrape these two parameters in Python.</h2>
<p><a href="https://github.com/lorenzibex/Scrape-Google-Scholar">https://github.com/lorenzibex/Scrape-Google-Scholar</a></p>
<h3>Analysis Notes</h3>
<p>Simple <code>scholarly</code> usage demo.</p>
<h2>VikramTiwari/google-scholarr-metadata-extraction</h2>
<p><a href="https://github.com/VikramTiwari/google-scholarr-metadata-extraction">https://github.com/VikramTiwari/google-scholarr-metadata-extraction</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla scraper, which grabs the BibTeX record from Scholar. <strong>JavaScript code</strong>. <a href="https://github.com/VikramTiwari/google-scholarr-metadata-extraction/blob/master/index.js">https://github.com/VikramTiwari/google-scholarr-metadata-extraction/blob/master/index.js</a></p>
<h2>utkarshsingh341/web-scraping-google-scholar: Web Scraping and Data Aquisition from Google Scholar</h2>
<p><a href="https://github.com/utkarshsingh341/web-scraping-google-scholar">https://github.com/utkarshsingh341/web-scraping-google-scholar</a></p>
<h2>pranjaljo/Google-Scholar-Network-Analysis</h2>
<p><a href="https://github.com/pranjaljo/Google-Scholar-Network-Analysis">https://github.com/pranjaljo/Google-Scholar-Network-Analysis</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla scraper</p>
<h2>istex/istex-google-scholar: A module for generating ISTEX holding description for Google Scholar Library Links</h2>
<p><a href="https://github.com/istex/istex-google-scholar">https://github.com/istex/istex-google-scholar</a></p>
<h3>Analysis Notes</h3>
<p>Very different purpose. Is an XSLT processor at its core.</p>
<p>From the README:</p>
<h4>Description</h4>
<p>Google Scholar allows the integration of OpenURL <abbr title="[object Object]">links</abbr> to full text resources contextualized with the electronic subscriptions associated to a given affiliation.</p>
<p>The integration of these <abbr title="[object Object]">links</abbr> to ISTEX resources follows these steps:</p>
<ol>
<li><strong>Description of the ISTEX holding</strong> thanks to Kbart files available with the BACON services (provided by ABES) in JSON and XML format. For example:</li>
</ol>
<ul>
<li>to get the complete list of packages available in BACON in json:</li>
</ul>
<p><a href="https://bacon.abes.fr/list.json">https://bacon.abes.fr/list.json</a></p>
<ul>
<li>to get the description of a particular package in XML format :</li>
</ul>
<p><a href="https://bacon.abes.fr/package2kbart/NPG_FRANCE_ISTEXJOURNALS.xml">https://bacon.abes.fr/package2kbart/NPG_FRANCE_ISTEXJOURNALS.xml</a></p>
<ol start="2">
<li><strong>Converting the ISTEX holding description</strong> from the Kbart XML format into the Google Scholar XML format defined at the following link :
<a href="https://scholar.google.com/intl/en/scholar/institutional_holdings.xml">https://scholar.google.com/intl/en/scholar/institutional_holdings.xml</a></li>
</ol>
<p>This is done by an XSLT style sheet applied to the Kbart files obtained via BACON for each ISTEX package.</p>
<ol start="3">
<li><strong>Creation of the Google Scholar form</strong> for requesting the activation of the OpenURL <abbr title="[object Object]">links</abbr>, also in XML :
<a href="https://scholar.google.com/intl/en/scholar/institutional_links.xml">https://scholar.google.com/intl/en/scholar/institutional_<abbr title="[object Object]">links</abbr>.xml</a></li>
</ol>
<p>This form will refer to the XML documents created at the step 2.</p>
<p>The files <code>institutional_links.xml</code> and <code>institutional_holdings.xml</code> for ISTEX can be validated by the dedicated DTD provided by Google.</p>
<ol start="4">
<li><strong>Submission of the form</strong>. The Google Scholar XML documents describing the holding in XML format are exposed on a web server. The URL of the main filled form file (<code>institutional_links.xml</code>) is sent by email to Google Scholar via their  address for support:
<a href="https://support.google.com/scholar/contact/general">https://support.google.com/scholar/contact/general</a></li>
</ol>
<p>Google Scholar indicates that the activation (and update) takes one to two weeks.</p>
<ol start="5">
<li><strong>Activation</strong> :</li>
</ol>
<p>After the setting by the user of his ISTEX affiliation in the Google Scholar settings, the <abbr title="[object Object]">links</abbr> to the ISTEX full texts will appear on the right side of the search results, for instance :</p>
<p><img src="doc/gs.png" alt="Example of links to full texts contextualized by the affiliation on Google Scholar"></p>
<ol start="6">
<li>
<p><strong>Update</strong> : the ISTEX holding description files can be regenerated by following the previous steps. It is only needed to replace the XML files exposed on internet and the Google Scholar crawler will take into account the new versions.</p>
</li>
<li>
<p>Here are some additional possible complementary elements doable by the <a href="https://github.com/istex/istex-browser-addon">ISTEX Browser Addon</a> :</p>
</li>
</ol>
<ul>
<li>
<p>Automatic setting of the <em>library <abbr title="[object Object]">links</abbr></em> affiliation in Google Scholar</p>
</li>
<li>
<p>Standard “button” for accessing the ISTEX full texts (actually it’s not really a button, simply decorated text easier to catch for a user and faster to render than bitmap) instead of the default Google Scholar text link, in order to have a consistent visual indication independently from the visited web site.</p>
</li>
</ul>
<h4>Build and run</h4>
<p>The goal of the present <em>node.js</em> module is to automate all the previously described steps in one single command line.
For updating the Google Scholar library <abbr title="[object Object]">links</abbr> and the different settings, simply re-execute the module.</p>
<h2>Coldflyer/Google-Scholar-Breadcrumbs-Builder</h2>
<p><a href="https://github.com/Coldflyer/Google-Scholar-Breadcrumbs-Builder">https://github.com/Coldflyer/Google-Scholar-Breadcrumbs-Builder</a></p>
<h3>Analysis Notes</h3>
<p>Vanilla scraper. <a href="https://github.com/Coldflyer/Google-Scholar-Breadcrumbs-Builder/blob/master/ScrapingGS.py#L15">https://github.com/Coldflyer/Google-Scholar-Breadcrumbs-Builder/blob/master/ScrapingGS.py#L15</a></p>
<h2>wl8837/Google-Scholar-API</h2>
<p><a href="https://github.com/wl8837/Google-Scholar-API">https://github.com/wl8837/Google-Scholar-API</a></p>
<h3>Analysis Notes</h3>
<p>Uses Selenium driver approach.</p>
<p>TODO from the README:</p>
<p>Proxy and Tor: Not fullfilled. Google can identify robots even if I use proxy and Tor.</p>
<h2>vignif/crawler-google-scholar: Download automatically statistics and pictures from google scholar’s researchers.</h2>
<p><a href="https://github.com/vignif/crawler-google-scholar">https://github.com/vignif/crawler-google-scholar</a></p>
<h3>Analysis Notes</h3>
<p>Uses vanilla approach, but mentions <code>scholarly</code> as a potential way forward. Might be interesting anyway as this one collects author data from Scholar; pretty neat code.</p>
<p>From the README:</p>
<p>this repo presents an automatic way of downloading statistics of a set of researchers or professors from the google scholar.
giving as input a list of [name surname] of researchers it retrieves data from google scholar such as {# of publications, h-index, i10-index and others}</p>
<p>the project scholarly (<a href="https://pypi.org/project/scholarly/">https://pypi.org/project/scholarly/</a>) probably allows me to do the same. I wanted
to find out a bit more regarding http requests and its implications.</p>
<p>get_stats_serial.py is waiting until each task(load webpage of researcher X) is completed, and only after that proceeds with the new author (Y).
this simple approach comes with the expense of time complexity O(N), meaning as long as the amount of researcher is ‘little’ it won’t require too much time.</p>
<p>This problem has a bottleneck in the speed which is the network, crawling the web is time expensive and the amount of request accepted by servers is limited and has to be respected.</p>
<p>A method to avoid the system staying idle while the web server responds is to allow multple tasks to run simultaneously.</p>
<p>get_stats_coroutine.py wants to exploit this strategy.</p>
<p>A proper timing sleep function must be setted inside each file in order to avoid rejection by the server.
If we are requesting informations too fast, the server will answer always with an [Error 429 Too Many Requests].</p>
<p>The serial script has been tested to query at a speed of 0,7 researcher per second.
The coroutine script has been tested to query at a speed of 0.05 researcher per second.</p>
<h2>sutlxwhx/scholar-parser: This is a PHP example of how you can use Phantom.js to extract <abbr title="[object Object]">links</abbr> from the first page of Google Scholar SERP in one page web application.</h2>
<p><a href="https://github.com/sutlxwhx/scholar-parser">https://github.com/sutlxwhx/scholar-parser</a></p>
<h3>Analysis Notes</h3>
<ul>
<li>Uses PhantomJS as headless browser.</li>
<li>Uses randomizing User-Agent strings to thwart Scholar police: “Randomize current user-agent for each request to avoid Google rate limiting” <a href="https://github.com/sutlxwhx/scholar-parser/blob/master/app/ua.php">https://github.com/sutlxwhx/scholar-parser/blob/master/app/ua.php</a></li>
<li>Has RECAPTCHA processing: “Receive recaptcha response for a current user. When I created this project I was not aware that there is official recaptcha PHP client library <a href="https://github.com/google/recaptcha">https://github.com/google/recaptcha</a>” <a href="https://github.com/sutlxwhx/scholar-parser/blob/master/app/functions.php">https://github.com/sutlxwhx/scholar-parser/blob/master/app/functions.php</a></li>
<li>Vanilla URL querying</li>
<li>PHP</li>
</ul>
<h2>xzk-seu/SpiderForGoogleScholar: 鱼塘</h2>
<p><a href="https://github.com/xzk-seu/SpiderForGoogleScholar">https://github.com/xzk-seu/SpiderForGoogleScholar</a></p>
<h2>madhawadias/google_scholar_scrapper: A scrapping tool to scrape article attributes from <a href="http://scholar.google.com">scholar.google.com</a></h2>
<p><a href="https://github.com/madhawadias/google_scholar_scrapper">https://github.com/madhawadias/google_scholar_scrapper</a></p>
<h2>LMBertholdo/google_scholar_crawler_coop</h2>
<p><a href="https://github.com/LMBertholdo/google_scholar_crawler_coop">https://github.com/LMBertholdo/google_scholar_crawler_coop</a></p>
<h2>aless80/Google-Scholar-scraper: Download information from Google Scholar for a number of author names</h2>
<p><a href="https://github.com/aless80/Google-Scholar-scraper">https://github.com/aless80/Google-Scholar-scraper</a></p>
<h2>LucasVadilho/nodeGoogleScholar</h2>
<p><a href="https://github.com/LucasVadilho/nodeGoogleScholar">https://github.com/LucasVadilho/nodeGoogleScholar</a></p>
<h2>jakeelkins/google-scholar-analysis: Some code I’m writing for analyzing research areas using google scholar, NLP, topic modeling, clustering, etc.</h2>
<p><a href="https://github.com/jakeelkins/google-scholar-analysis">https://github.com/jakeelkins/google-scholar-analysis</a></p>
<h2>sfhall/Google-Scholar-ID-Grabber: Python script that takes in an excel list and gets the Google Scholar ID for each name</h2>
<p><a href="https://github.com/sfhall/Google-Scholar-ID-Grabber">https://github.com/sfhall/Google-Scholar-ID-Grabber</a></p>
<h2>profmike/Google-Scholar-Stats: Parses author citation and h-index statistics from Google Scholar</h2>
<p><a href="https://github.com/profmike/Google-Scholar-Stats">https://github.com/profmike/Google-Scholar-Stats</a></p>
<h2>mogekag/sci-stat: Automated google scholar statistics crawler based on <a href="http://Scholar.py">Scholar.py</a></h2>
<p><a href="https://github.com/mogekag/sci-stat">https://github.com/mogekag/sci-stat</a></p>
<h2>hrlblab/ISN_KI_PubMed_GoogleScholar</h2>
<p><a href="https://github.com/hrlblab/ISN_KI_PubMed_GoogleScholar">https://github.com/hrlblab/ISN_KI_PubMed_GoogleScholar</a></p>
<h2>kylermurphy/scholar_plot: Simple Plot for google scholar</h2>
<p><a href="https://github.com/kylermurphy/scholar_plot">https://github.com/kylermurphy/scholar_plot</a></p>
<p>Simple Plot for google scholar and scopus information</p>
<p>Requires <a href="https://pybliometrics.readthedocs.io/en/stable/index.html">pybliometrics</a> for Scopus and <a href="https://github.com/OrganicIrradiation/scholarly">scholary</a> for Google Scholar.</p>
<p>pybliometrics was installed with pip, however it requires a license/network access and so publication numbers are hardcoded for now from <a href="https://www.scopus.com/freelookup/form/author.uri">Scopus Author seach</a></p>
<pre><code>pip install pybliometrics
</code></pre>
<p>scholary was installed via GitHub</p>
<pre><code>pip install -U git+https://github.com/OrganicIrradiation/scholarly.git
</code></pre>
<h2>couetilc/selenium-web-scraping: scraping google scholar using selenium</h2>
<p><a href="https://github.com/couetilc/selenium-web-scraping">https://github.com/couetilc/selenium-web-scraping</a></p>
<h3>Analysis Notes</h3>
<p>Selenium driver, obviously…</p>
<h2>crmne/googlescholarscraper: A scraper for Google Scholar, written in Python</h2>
<p><a href="https://github.com/crmne/googlescholarscraper">https://github.com/crmne/googlescholarscraper</a></p>
<p>GoogleScholarScraper is a <a href="https://scrapy.org/">Scrapy</a> project that implements a scraper for Google Scholar.</p>
<h2>Features</h2>
<ul>
<li>Extracts Authors, Title, Year, Journal, and Url.</li>
<li>Exports to CSV, JSON and BibTeX.</li>
<li>Cookie and referer support for higher query volumes.</li>
<li>Optimistically tries the next page in case of server errors.</li>
<li>Supports the full Google Scholar query syntax for authors, title, exclusions, inclusions, etc. Check out those <a href="http://www.otago.ac.nz/library/pdf/Google_Scholar_Tips.pdf">search tips</a>.</li>
</ul>
<h3>Analysis Notes</h3>
<p>Uses Scrapy, which I have yet to look into.</p>
<h2>callumparker/Google-Scholar-PDF-Link-Scraper: Scrape Google Scholar for PDF <abbr title="[object Object]">links</abbr> based on a keyword. Written in Python.</h2>
<p><a href="https://github.com/callumparker/Google-Scholar-PDF-Link-Scraper">https://github.com/callumparker/Google-Scholar-PDF-Link-Scraper</a></p>
<p>Scrape multiple Google Scholar pages for PDF <abbr title="[object Object]">links</abbr> based on a keyword(s).</p>
<ul>
<li>Automatically downloads PDF files to the directory of the script.</li>
<li>Creates a text file with PDF <abbr title="[object Object]">links</abbr>.</li>
</ul>
<h3>Analysis Notes</h3>
<p>Basic URL querying. Nothing fancy. Not even error handling.</p>
<h2>pradeepsen99/Google-Scholar-Web-App-DB: A web-app to visualize the different researchers on Google Scholar along with their relationships to other researchers.</h2>
<p><a href="https://github.com/pradeepsen99/Google-Scholar-Web-App-DB">https://github.com/pradeepsen99/Google-Scholar-Web-App-DB</a></p>
<h3>Analysis Notes</h3>
<p>Doesn’t seem to contain anything Google Scholar like.</p>
<p>Is a React website basic site AFAICT.</p>
<h2>ardirsaputra/Data-Mining-For-Google-Scholar: this repository used for educational purpose in the course data mining 2019 informatic engineer university of lampung</h2>
<p><a href="https://github.com/ardirsaputra/Data-Mining-For-Google-Scholar">https://github.com/ardirsaputra/Data-Mining-For-Google-Scholar</a></p>
<h3>Analysis Notes</h3>
<p>Looks like a website, <strong>without any scraper</strong>. There’s a ZIP file in the repo that <em>maybe</em> contains GS data, but I see no way this code is scraping GS, at least not in this initial quick scan. Nothing obvious or prominent, like <code>scholar.py</code> or <code>scholarly</code>. It’s PHP + JS code.</p>
<h2>janneliukkonen/google-scholar-results-counter-scraper: Small web scraper to quickly evaluate list of ML algorithms against whitepapers using Google Scholar.</h2>
<p><a href="https://github.com/janneliukkonen/google-scholar-results-counter-scraper">https://github.com/janneliukkonen/google-scholar-results-counter-scraper</a></p>
<h3>Analysis Notes</h3>
<p>basic scraper, nothing fancy. Uninteresting therefore.</p>
<h2>zhang-hz/zotero-autofetch: Zotero plugin for automatic download of PDFs from Scihub and Google Scholar</h2>
<p><a href="https://github.com/zhang-hz/zotero-autofetch">https://github.com/zhang-hz/zotero-autofetch</a></p>
<h3>Analysis Notes</h3>
<p>Since this looks like a FireFox addon (.xul files…) we <em>might</em> want to look into it a little further at some point: same idea we had for the Chrome extension but now for firefox, maybe?</p>
<h2>Manikaran20/Better_metrics_for_google_Scholars: This work is for all the scholars who have a google scholar profile, associated with the idea of providing a better and fairer results to them.</h2>
<p><a href="https://github.com/Manikaran20/Better_metrics_for_google_Scholars">https://github.com/Manikaran20/Better_metrics_for_google_Scholars</a></p>
<h3>Analysis Notes</h3>
<p>Selenium driver…</p>
<h2>goose0058/scholarbot: A small script to pull down references from google scholar.</h2>
<p><a href="https://github.com/goose0058/scholarbot">https://github.com/goose0058/scholarbot</a></p>
<h2>sarthak-patidar/scholar-crawler: A spider to crawl google scholar.</h2>
<p><a href="https://github.com/sarthak-patidar/scholar-crawler">https://github.com/sarthak-patidar/scholar-crawler</a></p>
<h3>Analysis Notes</h3>
<p>Hm. <s>Another Scrapy commercial Scraper API user!</s></p>
<h4><em>Update</em></h4>
<p>My bad! That’s <strong>not</strong> the commercial Scraper API, but <a href="https://scrapy.org/">Scrapy</a> i.e. <a href="https://scrapy.org/">https://scrapy.org/</a></p>
<p>Haven’t yet looked into that one to see what it does in terms of VPN hopping, UserAgent randomization, etc.</p>
<h2>theclementho/Scholar-Crawler: ECE496 Capstone - Crawler prototype for Google Scholar</h2>
<p><a href="https://github.com/theclementho/Scholar-Crawler">https://github.com/theclementho/Scholar-Crawler</a></p>
<h3>Analysis Notes</h3>
<p>Has its own copy of <code>scholarly</code> and runs on top of that one. To be inspected further at a later date.</p>
<h2>maze-runnar/my-scholarly: Use Scholarly to fetch google scholar data</h2>
<p><a href="https://github.com/maze-runnar/my-scholarly">https://github.com/maze-runnar/my-scholarly</a></p>
<p>Use Scholarly to fetch google scholar data</p>
<p>###Project description</p>
<p>scholarly is a module that allows you to retrieve author and publication information from Google Scholar in a friendly, Pythonic way.</p>
<h3>Usage</h3>
<p>Because scholarly does not use an official API, no key is required.</p>
<h3><strong>Stand on the shoulders of giants</strong></h3>
<p>Google Scholar provides a simple way to broadly search for scholarly literature. From one place, you can search across many disciplines and sources: articles, theses, books, abstracts and court opinions, from academic publishers, professional societies, online repositories, universities and other web sites. Google Scholar helps you find relevant work across the world of scholarly research.</p>
<h3>Analysis Notes</h3>
<p>Yada yada. See later if this adds any value on top of <code>scholarly</code>. It’s the grabbing that’s the hard part so I guess not, but I <em>could</em> be mistaken. (Yeah, I’m getting bitchy when the clock turns into the night and I’ve got a few more entries to go. Did that to myself, though, no-one else to blame…)</p>
<h2>akhilanto/GoogleScholar-WebScarping-Using-Free-VPN-in-Python: GoogleScholar Web Scraping using Free VPN In Python</h2>
<p><a href="https://github.com/akhilanto/GoogleScholar-WebScarping-Using-Free-VPN-in-Python">https://github.com/akhilanto/GoogleScholar-WebScarping-Using-Free-VPN-in-Python</a></p>
<h3>GoogleScholar-WebScraping-Using-VPN</h3>
<p>Since Google Scholar doesn’t provide any API  this Script can be used to Web scrap Google Scholar to get Citations and Authors for a Published paper. Here we are providing the papers from DBLP website. By using free VPN, this program overcomes the google captcha .The program works in the following way</p>
<ol>
<li>Importing Packages</li>
<li>Getting published papers from DBLP website for a provided link</li>
<li>Getting free VPN</li>
<li>Google Scholar web search  for the given paper</li>
<li>Scraping the Google Scholar</li>
<li>Converting the data into Data Frame and saving it as CSV output</li>
</ol>
<h3>Analysis Notes</h3>
<p>Now this sounds a lot like a basic <code>scholarly</code>. To be investigated further.</p>
<h2>jamespreed/scholar-crawler: Scrapes Google scholar to build a networks of co-authorship.</h2>
<p><a href="https://github.com/jamespreed/scholar-crawler">https://github.com/jamespreed/scholar-crawler</a></p>
<p>Because of captchas, this runs using selenium and Firefox, so you must have Firefox installed. This is currently designed for Windows, but the only Feel free to use the browser of your choice, you will need to roll your own session class.</p>
<h2>dgalaktionov/scholar.py: A parser for Google Scholar, written in Python</h2>
<p><a href="https://github.com/dgalaktionov/scholar.py">https://github.com/dgalaktionov/scholar.py</a></p>
<h3><a href="http://scholar.py">scholar.py</a></h3>
<p><strong>WARNING</strong>: This repository is a derived work from two different forks, from @machaerus and @jessamynsmith on the original repository in <a href="https://github.com/ckreibich/scholar.py">https://github.com/ckreibich/scholar.py</a>. This is the cleanest option I see for uploading the version I need, considering:</p>
<ul>
<li>The original project is obviously abandoned</li>
<li>Forking only one of the authors would be inaccurate</li>
<li><a href="https://www.niels-ole.com/ownership/2018/03/16/github-forks.html">Github can make you lose access on your forks</a>.</li>
</ul>
<p><code>scholar.py</code> is a Python module that implements a querier and parser for Google Scholar’s output. Its classes can be used independently, but it can also be invoked as a command-line tool.</p>
<p>The script used to live at <a href="http://icir.org/christian/scholar.html">http://icir.org/christian/scholar.html</a>, and I’ve moved it here so I can more easily manage the various patches and suggestions I’m receiving for <a href="http://scholar.py">scholar.py</a>. Thanks guys, for all your interest! If you’d like to get in touch, email me at <a href="mailto:christian@icir.org">christian@icir.org</a> or ping me <a href="http://twitter.com/ckreibich">on Twitter</a>.</p>
<p>Cheers,<br>
Christian</p>
<h3>Features</h3>
<ul>
<li>Extracts publication title, most relevant web link, PDF link, number of citations, number of online versions, link to Google Scholar’s article cluster for the work, Google Scholar’s cluster of all works referencing the publication, and excerpt of content.</li>
<li>Extracts total number of hits as reported by Scholar (new in version 2.5)</li>
<li>Supports the full range of advanced query options provided by Google Scholar, such as title-only search, publication date timeframes, and inclusion/exclusion of patents and citations.</li>
<li>Supports article cluster IDs, i.e., information relating to the variants of an article already identified by Google Scholar</li>
<li>Supports retrieval of citation details in standard external formats as provided by Google Scholar, including BibTeX and EndNote.</li>
<li>Command-line tool prints entries in CSV format, simple plain text, or in the citation export format.</li>
<li>Cookie support for higher query volume, including ability to persist cookies to disk across invocations.</li>
</ul>
<h3>Note</h3>
<p>I will always strive to add features that increase the power of this
API, but I will never add features that intentionally try to work
around the query limits imposed by Google Scholar. Please don’t ask me
to add such features.</p>
<h3>Analysis Notes</h3>
<p>Some folks can be too ethical. 😉 This is a <code>scholar.py</code> fork which isn’t listed as one. Have a look at what he did when the time comes.</p>
<h2>ukalwa/scholarly: A Node.js module to fetch and parse academic articles from google scholar</h2>
<p><a href="https://github.com/ukalwa/scholarly">https://github.com/ukalwa/scholarly</a></p>
<h3>Analysis Notes</h3>
<p>TypeScript module. Certainly DOES NOT have the features of <code>scholarly</code> (the Python module) as this one uses straight URL querying via cheeerio.</p>
<p>From the README:</p>
<p>A Node.js module to fetch and parse academic articles from Google Scholar.</p>
<h4>Acknowledgements</h4>
<p>This project was inspired from other awesome projects (<a href="https://github.com/ckreibich/scholar.py">scholar.py</a>, <a href="https://github.com/VT-CHCI/google-scholar">google-scholar</a>, and <a href="https://github.com/martinchapman/google-scholar-extended">google-scholar-extended</a>)</p>
<h2>Marcelobbr/web_crawler: Web crawler of Google Scholar profiles</h2>
<p><a href="https://github.com/Marcelobbr/web_crawler">https://github.com/Marcelobbr/web_crawler</a></p>
<p>For the web scraping to work with Google Chrome, you need to install chromedriver.</p>
<h3>Analysis Notes</h3>
<p>Ah well…</p>
<h2>lydianish/brag-gs: A Google Scholar API for BRAG</h2>
<p><a href="https://github.com/lydianish/brag-gs">https://github.com/lydianish/brag-gs</a></p>
<h3>Analysis Notes</h3>
<p>Uses <code>scholarly</code> to do the hard work…</p>
<h2>alexyashin/scholar-downloader: Chrome extension to download files from Google Scholar search result</h2>
<p><a href="https://github.com/alexyashin/scholar-downloader">https://github.com/alexyashin/scholar-downloader</a></p>
<h3>Analysis Notes</h3>
<p>Chrome extension. Code is 6 years old now. Still useful for PDF fetching? I don’t know. Not my first choice there.</p>
<h2>Rhaigtz/scholar-scraping: Creacion de funcion para scraping de google scholar.</h2>
<p><a href="https://github.com/Rhaigtz/scholar-scraping">https://github.com/Rhaigtz/scholar-scraping</a></p>
<h3>Analysis Notes</h3>
<p><a href="https://github.com/Rhaigtz/scholar-scraping/blob/master/src/utils/scholar.js">https://github.com/Rhaigtz/scholar-scraping/blob/master/src/utils/scholar.js</a> :
Rate limit detection, request rate limiting in an attempt to ccircumvent Google Scholar locking up. JavaScript code, looks clean to me.</p>
<h2>zouzhenhong98/scholartobib: a toot to grab bib info from google scholar, and write it to a bib file</h2>
<p><a href="https://github.com/zouzhenhong98/scholartobib">https://github.com/zouzhenhong98/scholartobib</a></p>
<h3>Analysis Notes</h3>
<p><a href="https://github.com/zouzhenhong98/scholartobib/blob/master/scholar.py">https://github.com/zouzhenhong98/scholartobib/blob/master/scholar.py</a> : randomized GoogleID for the query, SOCKS5 proxy (tor!), CAPTCHA detection, …</p>
<p>Comment from code: “Routes scholarly through a proxy (e.g. tor).        Requires pysocks.        Proxy must be running.”</p>
<p>It’s not <code>scholarly</code> but certainly using the same kind of mechanisms to thwart GS.</p>
<p>Interesting!</p>
<h2>Rosyuku/gssearch: google-scholar検索効率化</h2>
<p><a href="https://github.com/Rosyuku/gssearch">https://github.com/Rosyuku/gssearch</a></p>
<p>Search efficiency improvement</p>
<h3>Analysis Notes</h3>
<p>Looks a bit like an early(?) <code>scholarly</code>: UserAgent randomization is in there, but I don’t see proxy/VPN hopping, but that be me, my deteriorating eyes and the late hour. (Yup, been updating this document in reverse order as a stupid keyboard miss had me jump to the end of the tabs earlier and I didn’t want to screw up Chrome any more than I already had at that moment. Anyway, that’s nothing to bother you with so why am I writing this line?! :deep-thought:)</p>
<p>Here’s [the source code](<a href="https://github.com/Rosyuku/gssearch/blob/master/">https://github.com/Rosyuku/gssearch/blob/master/</a>&lt;google_scholar_search class=“py”&gt;&lt;/google_scholar_search&gt;)'s top comment:</p>
<blockquote>
<p>Created on Sun May 31 00:23:02 2020</p>
<p>@author: Wakasugi Kazuyuki</p>
<h3>Works Cited</h3>
<ul>
<li><a href="https://own-search-and-study.xyz/2019/06/09/python-scraping-icml2019-summary/">https://own-search-and-study.xyz/2019/06/09/python-scraping-icml2019-summary/</a></li>
<li><a href="https://serpapi.com/google-scholar-api">https://serpapi.com/google-scholar-api</a></li>
<li><a href="https://qiita.com/kuto/items/9730037c282da45c1d2b">https://qiita.com/kuto/items/9730037c282da45c1d2b</a></li>
<li><a href="https://github.com/scholarly-python-package/scholarly">https://github.com/scholarly-python-package/scholarly</a></li>
</ul>
</blockquote>
<h2>Neo-101/etudier-improved: Extract a citation network from Google Scholar</h2>
<p><a href="https://github.com/Neo-101/etudier-improved">https://github.com/Neo-101/etudier-improved</a></p>
<p><em>étudier</em> is a small Python program that uses [Selenium] and [requests-html] to
drive a <em>non-headless</em> browser to collect a citation graph around a particular
[Google Scholar] citation or set of search results. The resulting network is
written out as a [Gephi] file and a [D3] visualization using [networkx].
Current D3 visualization is inspired by [eyaler]. <em>The D3 visualization could
use some work, so if you add style to it please submit a pull request.</em></p>
<p>If you are wondering why it uses a non-headless browser it’s because Google is
[quite protective] of this data and routinely will ask you to solve a captcha
(identifying street signs, cars, etc in photos).  <em>étudier</em> will allow you to
complete these tasks when they occur and then will continue on its way
collecting data.</p>
<h3>Install</h3>
<p>You’ll need to install [ChromeDriver] before doing anything else. If you use
Homebrew on OS X this is as easy as:</p>
<pre><code>brew install chromedriver
</code></pre>
<p>Then you’ll want to install [Python 3] and:</p>
<pre><code>pip3 install etudier
</code></pre>
<h3>Run</h3>
<p>To use it you first need to navigate to a page on Google Scholar that you are
interested in, for example here is the page of citations that reference Sherry
Ortner’s [Theory in Anthropology since the Sixties]. Then you start <em>etudier</em> up
pointed at that page.</p>
<pre><code>% etudier 'https://scholar.google.com/scholar?start=0&amp;hl=en&amp;as_sdt=20000005&amp;sciodt=0,21&amp;cites=17950649785549691519&amp;scipsc='
</code></pre>
<p>If you are interested in starting with keyword search results in Google Scholar
you can do that too. For example here is the url for searching for “cscw memory”
if I was interested in papers that talk about the CSCW conference and memory:</p>
<pre><code>% etudier 'https://scholar.google.com/scholar?hl=en&amp;as_sdt=0%2C21&amp;q=cscw+memory&amp;btnG='
</code></pre>
<p>Note: it’s important to quote the URL so that the shell doesn’t interpret the
ampersands as an attempt to background the process.</p>
<h3>–pages</h3>
<p>By default <em>étudier</em> will collect the 10 citations on that page and then look at
the top 10 citatations that reference each one. So you will end up with no more
than 100 citations being collected (10 on each page * 10 citations).</p>
<p>If you would like to get more than one page of results use the <code>--pages</code>. For
example this would result in no more than 400 (20 * 20) results being collected:</p>
<pre><code>% etudier --pages 2 'https://scholar.google.com/scholar?start=0&amp;hl=en&amp;as_sdt=20000005&amp;sciodt=0,21&amp;cites=17950649785549691519&amp;scipsc=' 
</code></pre>
<h2>bsodhi/books_scraper: Books scraper for Google Scholar and Goodreads</h2>
<p><a href="https://github.com/bsodhi/books_scraper">https://github.com/bsodhi/books_scraper</a></p>
<h3>Prerequisites</h3>
<ol>
<li>Install Python for your operating. You can <a href="https://www.python.org/downloads/release/python-382/">download Python 3.8.2 from here</a>.</li>
<li>This program makes use of <a href="https://www.selenium.dev/documentation/en/webdriver/driver_requirements/">Selenium WebDriver</a>
for fetching GoodReads book shelf data. You should have a driver installed for your
browser. Currently supported browsers are: Chrome, Firefox, Edge and Safari. We have tested with Firefox and Safari (on macOSX 10.14.6).</li>
</ol>
<h2>coryjcombs/Scholar-search: Multi-page, multi-term scraper for Google Scholar results</h2>
<p><a href="https://github.com/coryjcombs/Scholar-search">https://github.com/coryjcombs/Scholar-search</a></p>
<h3>Scholar-Search</h3>
<p>A multi-page, multi-term scraper for Google Scholar results (version 1.0.6).</p>
<h3>Background</h3>
<p>This scraper was developed for use in a systematic review of scholarship on electricity generation, co-authored by Sarah M. Jordaan, Cory J. Combs, and Edeltraud Günther. The collected data served as the basis for an article being prepared for submission in early 2020.</p>
<h3>Details</h3>
<ul>
<li>Designed to scrape all results of Google Scholar searches, up to Scholar’s imposed maximum of 100 pages (1000 results) for each search.</li>
<li>Developed using BeautifulSoup, Pandas, and the requests and time packages.</li>
</ul>
<h3>Credits</h3>
<ul>
<li>This code builds upon a single-page scraper for <a href="http://Google.com">Google.com</a> search results developed by Edmund Martin, whose original work is <a href="https://edmundmartin.com/scraping-google-with-python/">available here</a>. Many thanks and all due credit to Edmund Martin!</li>
<li>Adaptation for Google Scholar, as well as iteration over pages, data extraction and manipulation, and export control were coded by Cory J. Combs.</li>
</ul>
<h3>Scraper Components</h3>
<ol>
<li>A user agent, which provides identifying information to the server</li>
<li>A function to fetch results</li>
<li>A function to parse results</li>
<li>An function to execute fetching and parsing with error handlers</li>
<li>The main search script, which:</li>
</ol>
<ul>
<li>executes the search with the input parameters,</li>
<li>outputs the results in a pandas data frame,</li>
<li>extracts metadata elements not consistently identifiable through Google Scholar’s html or xml alone,</li>
<li>cleans and formats the data, and</li>
<li>exports the fully formatted dataframe into Excel.</li>
</ul>
<p>The results may be explored in the output Excel file or in Python using pandas. The final formatted pandas data frame is called “data_df_clean” by default.</p>
<h3>Ethical Scraping</h3>
<p>Without appropriate constraints, web scraping can cause undue stress on a server. As such, special care was taken in implementing this scraper to ensure ethical use of server requests, first by scripting pauses between both page iterations and individual result collections, and second by separating execution of each search across the day, over multiple days, and avoiding peak usage times. When developing the script, a sample test was manually confirmed to yield a small number of results prior to execution to avoid unnecessary server burden.</p>
<p>For an interesting exploration of scraping Google Scholar results at a far larger scale, and through different means, see <a href="https://www.nature.com/articles/d41586-018-04190-5">Else 2018 in Nature</a>.</p>
<h3>Analysis Notes</h3>
<p>Right. Right. Anyway, this one uses UserAgent spoofing and nothing else, just plain website requesting.</p>
<p>Now for the referenced articles:</p>
<h4><a href="https://edmundmartin.com/scraping-google-with-python/">https://edmundmartin.com/scraping-google-with-python/</a></h4>
<p>That’s basically <code>scholar.py</code> so no magic what-so-ever.</p>
<h4><a href="https://www.nature.com/articles/d41586-018-04190-5">https://www.nature.com/articles/d41586-018-04190-5</a></h4>
<p>Quoting a bit here (<abbr title="[object Object]">emphasis</abbr> mine):</p>
<blockquote>
<h3>How did you get around the fact that Google Scholar has no API?</h3>
<p>We spent three months scraping data from the website. I created a script to do so, but I had to be there to keep manually solving the CAPTCHAs that appeared regularly.
It was a boring summer! We used several computers to distribute the enquiries because Google Scholar asks you to solve a CAPTCHA if one computer is making too many requests.
<strong>Sometimes the CAPTCHAs appear so frequently that it is not practical to get the data this way. We don’t think it is a reliable method of getting the data.</strong></p>
<h3>How many CAPTCHAs did you solve over the course of the experiment?</h3>
<p>I can’t tell you the exact number, but many hundreds!</p>
<h3>How long would it have taken to extract the data if an API was available from Google Scholar?</h3>
<p>One or two days.</p>
</blockquote>
<p>And there you have it: that’s basically what we’re fighting: it’s a tug of war with the Google engineers. Personally, I think <code>scholarly</code> is closest to a workable/usable scraper (there’s the “Scraper API” mentioned elsewhere in this doc, which turns out to be a commercial SaaS version of that one AFAICT from their blurbs. Maybe with some added Mechanical Turk if you buy the more expensive licenses of theirs, but otherwise just <code>scholarly</code> and that’s it. Note ny own findings / guestimates regarding VPN IP blocking: Google doesn’t need to maintain a blacklist manually there: all they have to do is monitor the incoming IP addresses and do a DNS reverse lookup to see if an IP address that’s frequenting their Scholar site belongs to a VPN company like NordVPN and then it’s down to counting requests and ‘downgrading’ those IP numbers when you encounter them. At least that’s what <em>I</em> would do if I were in their shoes: it’s fast, doesn’t need manual maintenance and all you have to do is be more strict enforcing your limits on these ‘suspect’ IP numbers. Since you have no published limits on Scholar anyway, you can get away with throttling the suspect ones and if someone complains the ball is in their court to proove that they are <strong>not</strong> using a VPN or proxy for their Scholar visits. Which leaves the rather more fluid(?) <code>tor</code> network… Which’ exit nodes can be detected too, I suppose. Hm. I wonder what FSF’s panopticon would say about the fingerprint of such a proxied visit: is it recognizable from a regular Chrome browser visit? I suppose so, as I seem to recall some older NSA/FBI work re ‘cracking’ darknet origins by monitoring tor exit nodes… Though I must say I don’t recall how that one was done back in the day – it’s been a few years.)</p>
<h2>edwardmfho/ScholarScrape: Google Scholar strangely does not has its own API. I use a rather stupid way to scrape the title and authors’ name from the scholar search query. Will expand the functionality of this repo in the future.</h2>
<p><a href="https://github.com/edwardmfho/ScholarScrape">https://github.com/edwardmfho/ScholarScrape</a></p>
<h3>Analysis Notes</h3>
<p>And another Selenium driver to kick off Chrome for browsing Google Scholar…</p>
<h2>aakashchandhoke/SpiderUnleashed: SpiderUnleashed is a webcrawler that retrieves the non-pdf results from educational websites because pdfs are easily available on Google Scholar. The application uses the inbuilt library of HTTrack that crawls the webpages of the provided topic to the application.</h2>
<p><a href="https://github.com/aakashchandhoke/SpiderUnleashed">https://github.com/aakashchandhoke/SpiderUnleashed</a></p>
<h3>Analysis Notes</h3>
<p>C# code. No magicks re Google Scholar quirks: <a href="https://github.com/aakashchandhoke/SpiderUnleashed/blob/master/LinksCrawler.cs">https://github.com/aakashchandhoke/SpiderUnleashed/blob/master/LinksCrawler.cs</a></p>
<p>The mention of HTTrack in that description has me wondering, but only for a bit.</p>
<h2>erenkarabacak/scholar_app: Simple Google Scholar Web Application (Created by using scholarly and Flask)</h2>
<p><a href="https://github.com/erenkarabacak/scholar_app">https://github.com/erenkarabacak/scholar_app</a></p>
<h2>glamrock/hypnoscholar: A twitterbot, whose primary function is to post Google Scholar <abbr title="[object Object]">links</abbr>.</h2>
<p><a href="https://github.com/glamrock/hypnoscholar">https://github.com/glamrock/hypnoscholar</a></p>
<h3>Analysis Notes</h3>
<p>Just a bit of <em>fun stuff</em>. Ruby code.</p>
<h2>maurice-schleussinger/SLR-Tools: Python scripts to perform a systematic literature review for Google Scholar and others</h2>
<p><a href="https://github.com/maurice-schleussinger/SLR-Tools">https://github.com/maurice-schleussinger/SLR-Tools</a></p>
<h3>Analysis Notes</h3>
<p>Uses rate limiting in an attempt to prevent robot detection to trigger, but no other magicks are performed it seems: <a href="https://github.com/maurice-schleussinger/SLR-Tools/blob/master/crawl_googlescholar.py">https://github.com/maurice-schleussinger/SLR-Tools/blob/master/crawl_googlescholar.py</a></p>
<p>Here’s the latest relevant commit message on that subject, 9 months ago: <a href="https://github.com/maurice-schleussinger/SLR-Tools/commit/23cad9975dd0f7547cba393c85709ff48f5cd84b">https://github.com/maurice-schleussinger/SLR-Tools/commit/23cad9975dd0f7547cba393c85709ff48f5cd84b</a></p>
<h2>Ze1598/Scrape-Academic-Social-Networks: Scrape information from Google Scholar, ResearchGate and <a href="http://Academia.edu">Academia.edu</a> with Python and Selenium</h2>
<p><a href="https://github.com/Ze1598/Scrape-Academic-Social-Networks">https://github.com/Ze1598/Scrape-Academic-Social-Networks</a></p>
<p>For a college project, me and a classmate had to find out how many documents the authors of each school from Instituto Politécnico do Porto (IPP) had published, along with some other metrics, in academic social networks, specifically Google Scholar, ResearchGate and <a href="http://Academia.edu">Academia.edu</a>. Unfortunately, there’s still no API support for none of them, and so I had to scrape this information with Python and Selenium.</p>
<p>These scripts are by no means API for the platforms, since they were tailored to our need, but I think these scripts offer a solid base for someone looking to start a project like that.</p>
<p>Due note that, because these scripts (Selenium) rely on a Google Chrome driver, you need to specify the path where it’s located. For my case, executing the driver once and having it in the same folder as the scripts was enough to run the script successfully afterwards.</p>
<p>The code will probably be a bit messy as I was more worried about getting the results than making the code readable and/or maintainable in the long run, but I feel it’s still clear enough as I wrote docstrings for every function and wrote comments for everything.</p>
<p>External sources:</p>
<ul>
<li>
<p>Selenium: <a href="https://www.seleniumhq.org/">https://www.seleniumhq.org/</a></p>
</li>
<li>
<p>Google Chrome’s driver download: <a href="https://chromedriver.storage.googleapis.com/index.html?path=73.0.3683.68/">https://chromedriver.storage.googleapis.com/index.html?path=73.0.3683.68/</a></p>
</li>
<li>
<p>Google Scholar: <a href="https://scholar.google.com/">https://scholar.google.com/</a></p>
</li>
<li>
<p>ResearchGate: <a href="https://www.researchgate.net/">https://www.researchgate.net/</a></p>
</li>
<li>
<p><a href="http://Academia.edu">Academia.edu</a>: <a href="https://www.academia.edu/">https://www.academia.edu/</a></p>
</li>
</ul>
<h2>murfel/pauper-scholar: 🎓A Chrome extension that allows to differentiate between free-access and paid-access articles in search results on Google Scholar.</h2>
<p><a href="https://github.com/murfel/pauper-scholar">https://github.com/murfel/pauper-scholar</a></p>
<h3>Pauper Scholar — Get it in [Chrome Web Store]</h3>
<p>Pauper Scholar is a Chrome extension for the Google Scholar website which adds an ability to differentiate between free-access and paid-access articles, in particular, it can hide all paid-access articles in search results.</p>
<p>An article is considered to be a free-access one if there’s a link to a paper next to it.</p>
<h3>Analysis Notes</h3>
<p><strong>Question</strong>: what’s keeping me from having that part of the Google Sniffer done as a Chrome extension instead? We can communicate across applications using websockets &amp; localhost, after all, so we could take the idea of the next repo (ag-gipp/recvis-tiny-scholar-api) along with this one and mix that into a Chrome extension which talks to Qiqqa…</p>
<h2>ag-gipp/recvis-tiny-scholar-api: This is for creating single purposed unofficial temporary Google Scholar API that will serve RecVis project.</h2>
<p><a href="https://github.com/ag-gipp/recvis-tiny-scholar-api">https://github.com/ag-gipp/recvis-tiny-scholar-api</a></p>
<p>This project is meant to be used as very small unofficial Google Scholar API for fetching bibliographic data based on input academic paper title. This API painfully slows down requests down to one request per 2 minute because Google Scholar is aggressively blocking the fetching process otherwise. Tiny Scholar API, whenever successfully fetching process happens, caches the request and doesn’t count it towards API fetching limit of one document per 2 minutes.</p>
<h3>Analysis Notes</h3>
<p>JavaScript code, which uses puppeteer, a headless browser. No special Google Scholar quirks circumvention sauce, apart from that slow rate of querying: one result per 2 minutes.</p>
<h2>aokabi/scholar-chrome-extension: Google Scholarの検索結果をリスト出力するChrome拡張</h2>
<p><a href="https://github.com/aokabi/scholar-chrome-extension">https://github.com/aokabi/scholar-chrome-extension</a></p>
<h3>Analysis Notes</h3>
<p>Alas, the tough bit is done by the browser. Nothing useful in this code. <a href="https://github.com/aokabi/scholar-chrome-extension/blob/master/src/content_scripts.js">https://github.com/aokabi/scholar-chrome-extension/blob/master/src/content_scripts.js</a></p>
<h2>driss14/googlescholarselenium: Simple script to download google scholar search to csv file using selenium web driver and beautiful soup</h2>
<p><a href="https://github.com/driss14/googlescholarselenium">https://github.com/driss14/googlescholarselenium</a></p>
<p>Simple supervised script to parse google scholar search to csv file using selenium web driver and beautiful soup.</p>
<h2>adbrucker/scholar-kpi: A tool for analysing publication related key performance indicates (KPIs) based on the information available at the Google Scholar page of an author.</h2>
<p><a href="https://github.com/adbrucker/scholar-kpi">https://github.com/adbrucker/scholar-kpi</a></p>
<h3>Analysis Notes</h3>
<p><a href="https://github.com/adbrucker/scholar-kpi/blob/master/src/LogicalHacking.ScholarKpi/Scraper/GoogleScholar.fs">Scrapes Google Scholar using F#</a> which is cool and everything, but there’s no error checking for the usual Google Scholar quirks AFAICT.</p>
<h2>bcmechen/find-pmid: Chrome extension that finds and displays PMID on Google Scholar</h2>
<p><a href="https://github.com/bcmechen/find-pmid">https://github.com/bcmechen/find-pmid</a></p>
<p>Find PMID is a Google Chrome extension that uses Entrez Programming Utilities (E-utilities) to find PMID (unique identifier used in PubMed), displays PMID, and provides one click access to the article page in PubMed for Google Scholar’s results.</p>
<h3>Analysis Notes</h3>
<p>Accessed the PubMed website: <a href="https://pubmed.ncbi.nlm.nih.gov/">https://pubmed.ncbi.nlm.nih.gov/</a></p>
<h2>lachrist/oghma: Oghma (responsibly) scrapes citation graphs from google-scholar</h2>
<p><a href="https://github.com/lachrist/oghma">https://github.com/lachrist/oghma</a></p>
<p>Oghma is a command-line tool for scraping a citation graph from <a href="https://scholar.google.com/">google-scholar</a> starting from some seminal works.
<a href="https://scholar.google.com/">google-scholar</a> will prompt a captcha from time to time even though Oghma uses Selenium and only launches requests every 5 to 10 seconds.
In which case a notification will pop-up; once you resolved the capcha, you can press <code>&lt;enter&gt;</code> in the terminal to resume the scraping.
Using a Firefox profile can help to remain undercover; being logged in a <a href="https://mail.google.com">gmail</a> account in this profile is even better.</p>
<h2>jessebrennan/citation_scraper: Pulls and formats citations for authors from Google Scholar</h2>
<p><a href="https://github.com/jessebrennan/citation_scraper">https://github.com/jessebrennan/citation_scraper</a></p>
<h3>Intro</h3>
<p>This is software used to scrape Google Scholar for citations by a
particular author. It makes use of ckreibich’s <a href="https://pybliometrics.readthedocs.io/en/stable/index.html">scholar.py</a>, with
a couple of <a href="https://github.com/OrganicIrradiation/scholarly">modifications</a>.</p>
<h3>Features</h3>
<h4>Caching</h4>
<p>Google blocking the program mid-run used to be a show stopper. All
of the citations already scraped would be lost and the program would
crash. Until… <strong>CACHING!</strong></p>
<p>Every time all of the citations for a particular author are scraped
they are added to a cache file called <code>.pickle_cache.dat</code> which is
created in the directory where the program is run. If the program
crashes due to a KeyboardInterrupt (^C) or from a 503 from Google’s
servers, the progress so far is saved to this file so that on the next
run the scraping can resume from where it left off.</p>
<h4>Refined Search</h4>
<p>Sometimes you want to limit your search only to authors that are part
of a particular institute or university. By using the <code>--words</code> option
one can specify that so that it’s reflected in the results. For example
<code>--words &quot;UC Santa Cruz Genomics Institute&quot;</code> will give only results
from authors within that institute.</p>
<h4>Waiting</h4>
<p>the <code>--wait</code> option can be used to wait for a specified number of
seconds between each query with the hopes that this won’t upset Google.
The effectiveness of this solution has not been verified.</p>
<h3>Trouble shooting</h3>
<p>Probably the only problem you will encounter is getting blocked by
Google Scholar’s API. There is a workaround!</p>
<p>You need:</p>
<ol>
<li>
<p>Mozilla Firefox</p>
</li>
<li>
<p>A Firefox extension that allows you to export cookies in the
Netscape cookie file format such as <a href="https://addons.mozilla.org/en-US/firefox/addon/cookie-exporter/">Cookie Exporter</a>.</p>
</li>
</ol>
<p>Then:</p>
<ol start="3">
<li>
<p>Navigate to one of the URLs that failed when requested (using
Firefox)</p>
</li>
<li>
<p>Fill out the captcha</p>
</li>
<li>
<p>Export the cookies from the page (as <code>cookies.txt</code>)</p>
</li>
<li>
<p>Save the file and run again but specify the <code>-c</code> option. For example</p>
<pre class="language-bash"><code class="language-bash">$ python3 citation_scraper zeppelin.txt output.txt -c cookies.txt
</code></pre>
</li>
</ol>
<h2>jjwallman/gscholartex: Parse saved Google Scholar webpage to extract citation data</h2>
<p><a href="https://github.com/jjwallman/gscholartex">https://github.com/jjwallman/gscholartex</a></p>
<p>The Google Scholar API is a little difficult and blocks repeated requests. I have not been able to find a way to load a profile with a specific number of citations showing, hence the manual steps.</p>
<h2>ShuDiamonds/twitterbot_googlescholar: the app aim is to send the infomation which is the result of thesis title analysis from google scholar</h2>
<p><a href="https://github.com/ShuDiamonds/twitterbot_googlescholar">https://github.com/ShuDiamonds/twitterbot_googlescholar</a></p>
<h3>Analysis Notes</h3>
<p>Looks rather unfinished or uses external services? <a href="https://github.com/ShuDiamonds/twitterbot_googlescholar/blob/master/posttweet.py">https://github.com/ShuDiamonds/twitterbot_googlescholar/blob/master/posttweet.py</a></p>
<h2>lalit3370/scrapy-googlescholar: Scraping google scholar for user page and citations page using scrapy and creating an API with scrapyrt</h2>
<p><a href="https://github.com/lalit3370/scrapy-googlescholar">https://github.com/lalit3370/scrapy-googlescholar</a></p>
<h3>Analysis Notes</h3>
<p>Huh? README says:</p>
<blockquote>
<ol start="13">
<li>Create a Scraper API account if you don’t want to get banned from google</li>
<li>Copy your API key and paste it in topl_project/topl_project/spiders/1.py lines 22 and 52</li>
</ol>
</blockquote>
<p>Now I wonder what that Scraper API is… A-ha!</p>
<p><a href="https://www.scraperapi.com/">https://www.scraperapi.com/</a></p>
<p>Proxy API for Web Scraping</p>
<p>Scraper API handles proxies, browsers, and CAPTCHAs, so you can get the HTML from any web page with a simple API call!</p>
<p><a href="https://www.scraperapi.com/pricing">https://www.scraperapi.com/pricing</a></p>
<p>One of the most frustrating parts of automated web scraping is constantly dealing with IP blocks and CAPTCHAs. Scraper API rotates IP addresses with each request, from a pool of millions of proxies across over a dozen ISPs, and automatically retries failed requests, so you will never be blocked. Scraper API also handles CAPTCHAs for you, so you can concentrate on turning websites into actionable data.</p>
<hr>
<p>So that looks like a commercial <a href="http://scholarly.py">scholarly.py</a> SaaS. 🤔</p>
<p>Meanwhile, there’s a API key apparently in an older commit, as there’s this commit: <a href="https://github.com/lalit3370/scrapy-googlescholar/commit/0b332967a35e9132073ee0f7fb18dcd57947f2c9">https://github.com/lalit3370/scrapy-googlescholar/commit/0b332967a35e9132073ee0f7fb18dcd57947f2c9</a>
which impacts <a href="https://github.com/lalit3370/scrapy-googlescholar/blob/master/topl_project/topl_project/spiders/1.py">https://github.com/lalit3370/scrapy-googlescholar/blob/master/topl_project/topl_project/spiders/1.py</a></p>
<h2>aptaheri/covid_response: Python scripts to extract text from Google Scholar docs</h2>
<p><a href="https://github.com/aptaheri/covid_response">https://github.com/aptaheri/covid_response</a></p>
<h2>philnova/citationscraper: Short script to pull well-formatted citations from Google scholar</h2>
<p><a href="https://github.com/philnova/citationscraper">https://github.com/philnova/citationscraper</a></p>
<p>Uses selenium to scrape formatted citations from Google Scholar.</p>
<p>We need to control a real browser instance, rather than just making HTTP requests,
because the actual citation is hidden behind a modal window. To get it, we need
to interact with JavaScript on the Scholar page, so we need a zombie browser.</p>
<p>N.B. Google Scholar won’t be happy about being scraped. Repeated use of this script
may lead to you being temporarily locked out.</p>
<h2>brinsonaml/PaperCrawler: Use Google scholar to search for papers and crawl content</h2>
<p><a href="https://github.com/brinsonaml/PaperCrawler">https://github.com/brinsonaml/PaperCrawler</a></p>
<h3>Analysis Notes</h3>
<p>Carries a copy (edited?) of <a href="http://scholar.py">scholar.py</a></p>
<p>Has code (<code>crawler.py</code>) which scrapes publications.
Journals include:</p>
<ul>
<li>IEEE proceedings</li>
<li>Elsevier: Composite science and technology</li>
<li>ACS</li>
</ul>
<h2>machetazo/sme: script de python que analiza resultados de google scholar</h2>
<p><a href="https://github.com/machetazo/sme">https://github.com/machetazo/sme</a></p>
<h3>Analysis Notes</h3>
<p>scraper uses <code>scholarly</code>: <a href="https://github.com/machetazo/sme/blob/master/sme/scraper.py#L3">https://github.com/machetazo/sme/blob/master/sme/scraper.py#L3</a></p>
<p>Translation: “we use these headers so that google believes we are firefox” at <a href="https://github.com/machetazo/sme/blob/master/sme/scraper.py#L20">https://github.com/machetazo/sme/blob/master/sme/scraper.py#L20</a>
so I guess they’re not doing UserAgent randomization here?</p>
<h1>Microsoft Academic Search</h1>
<h2>MicrosoftDocs/microsoft-academic-services</h2>
<p><a href="https://github.com/MicrosoftDocs/microsoft-academic-services">https://github.com/MicrosoftDocs/microsoft-academic-services</a></p>
<h2>Azure-Samples/academic-knowledge-analytics-visualization: Various examples to perform big data analytics over Microsoft Academic Graph and visualize the results.</h2>
<p><a href="https://github.com/Azure-Samples/academic-knowledge-analytics-visualization">https://github.com/Azure-Samples/academic-knowledge-analytics-visualization</a></p>
<h2>milindhg/Microsoft-Academic-Graph</h2>
<p><a href="https://github.com/milindhg/Microsoft-Academic-Graph">https://github.com/milindhg/Microsoft-Academic-Graph</a></p>
<h2>Azure-Samples/microsoft-academic-graph-pyspark-samples: Sample PySpark code for interacting with the Microsoft Academic Graph</h2>
<p><a href="https://github.com/Azure-Samples/microsoft-academic-graph-pyspark-samples">https://github.com/Azure-Samples/microsoft-academic-graph-pyspark-samples</a></p>
<h2>microsoft/mag-covid19-research-examples: Examples or utilizing Microsoft Academic for conducting covid-19 research</h2>
<p><a href="https://github.com/microsoft/mag-covid19-research-examples">https://github.com/microsoft/mag-covid19-research-examples</a></p>
<h3>Official Microsoft Sample</h3>
<!-- 
Guidelines on README format: https://review.docs.microsoft.com/help/onboard/admin/samples/concepts/readme-template?branch=master

Guidance on onboarding samples to docs.microsoft.com/samples: https://review.docs.microsoft.com/help/onboard/admin/samples/process/onboarding?branch=master

Taxonomies for products and languages: https://review.docs.microsoft.com/new-hope/information-architecture/metadata/taxonomies?branch=master
-->
<p>The code samples provided here provide WHO / PubMed ID -&gt; MAG ID mapping data as well
as code examples showing how to perform COVID-19 related analysis against the
<a href="https://www.microsoft.com/en-us/research/project/microsoft-academic-graph/">MAG</a> Dataset
and <a href="https://www.microsoft.com/en-us/research/project/academic-knowledge/">Project Academic Knowledge API</a>
or <a href="https://docs.microsoft.com/en-us/academic-services/knowledge-exploration-service/">MAKES API</a>.</p>
<h2>ropensci/microdemic: microsoft academic client</h2>
<p><a href="https://github.com/ropensci/microdemic">https://github.com/ropensci/microdemic</a></p>
<h2>microsoft/academic-knowledge-exploration-services-utilities: Utility tools and scripts for interacting with Microsoft Academic Knowledge Exploration Service (MAKES)</h2>
<p><a href="https://github.com/microsoft/academic-knowledge-exploration-services-utilities">https://github.com/microsoft/academic-knowledge-exploration-services-utilities</a></p>
<h2>jimbobbennett/MicrosoftAcademicContent: This repository lists content suitable for students/faculty to learn Azure and other Microsoft technologies</h2>
<p><a href="https://github.com/jimbobbennett/MicrosoftAcademicContent">https://github.com/jimbobbennett/MicrosoftAcademicContent</a></p>
<h2>subhash-pujari/MicrosoftAcademicSearchCrawler: This is the crawler for querying the microsoft academic search APIs in BFS(breadth first search way starting from the root node). We get a JSON response which is parsed and saved to the database.</h2>
<p><a href="https://github.com/subhash-pujari/MicrosoftAcademicSearchCrawler">https://github.com/subhash-pujari/MicrosoftAcademicSearchCrawler</a></p>
<h2>andreas-wilm/awesome-academic-graph: Awesome list for Microsoft Academic Graph</h2>
<p><a href="https://github.com/andreas-wilm/awesome-academic-graph">https://github.com/andreas-wilm/awesome-academic-graph</a></p>
<p>Awesome list for Microsoft Academic Graph (MAG)</p>
<h3>About MAG: comparisons, coverage etc.</h3>
<ul>
<li><a href="https://link.springer.com/article/10.1007%2Fs11192-019-03114-y">Two new kids on the block: How do Crossref and Dimensions compare with Google Scholar, Microsoft
Academic, Scopus and the Web of Science? (May, 2019)</a></li>
<li><a href="https://www.microsoft.com/en-us/research/project/academic/articles/cost-of-tracking-research-trends-and-impacts-with-microsoft-academic-graph/">Cost of tracking research trends and impacts with Microsoft Academic Graph (Feb 2019)</a></li>
<li><a href="https://harzing.com/blog/2017/11/publish-or-perish-version-6">Publish or Perish version 6 (Nov 2017)</a></li>
<li><a href="https://arxiv.org/ftp/arxiv/papers/1711/1711.08767.pdf">Microsoft Academic: A multidisciplinary comparison of citation counts with Scopus and Mendeley for 29 journals (Nov, 2017)</a></li>
<li><a href="https://arxiv.org/ftp/arxiv/papers/1703/1703.05539.pdf">The coverage of Microsoft Academic: Analyzing the publication output of auniversity (Sep 2017)</a></li>
<li><a href="http://www.dlib.org/dlib/september16/herrmannova/09herrmannova.html">An Analysis of the Microsoft Academic Graph (Sept 2016)</a></li>
<li><a href="http://cm.cecs.anu.edu.au/post/citation_analysis/">Eight Years of WSDM: Increasing Influence and Diversifying Heritage (Feb 2016)</a></li>
</ul>
<!-- - [Comparison of Microsoft Academic (Graph) with Web of Science, Scopus and Google Scholar](https://eprints.soton.ac.uk/408647/1/microsoft_academic_msc.pdf) -->
<ul>
<li><a href="https://www.frontiersin.org/articles/10.3389/fdata.2019.00045/full">A Review of Microsoft Academic Services for Science of Science Studies (Dec 2019)</a></li>
<li><a href="https://www.cwts.nl/blog?article=n-r2x284">CWTS: Mapping science using Microsoft Academic data</a></li>
</ul>
<h3>Analyses using MAG</h3>
<ul>
<li><a href="https://github.com/Azure-Samples/academic-knowledge-analytics-visualization">Analytics &amp; Visualization Samples for Academic Graph</a></li>
<li><a href="https://medium.com/ai2-blog/china-to-overtake-us-in-ai-research-8b6b1fe30595">China to Overtake US in AI Research (March, 2019)</a></li>
<li><a href="https://mdxminds.com/2016/11/17/microsoft-academic-is-the-phoenix-getting-wings/">Microsoft Academic: Is the Phoenix getting wings? (Nov 2017)</a></li>
<li><a href="https://arxiv.org/pdf/1704.05150.pdf">A Century of Science: Globalization of Scientific Collaborations,Citations, and Innovationsi (Aug, 2017)</a></li>
<li><a href="https://www.ncbi.nlm.nih.gov/pmc/articles/PMC5023123/">PR-Index: Using the h-Index and PageRank for Determining True Impact (Sept, 2016)</a></li>
<li><a href="http://cm.cecs.anu.edu.au/post/citation_vis/">Visualizing Citation Patterns of Computer Science Conferences (Aug, 2016)</a></li>
<li><a href="https://dl.acm.org/citation.cfm?doid=2872518.2890525">Investigations on Rating Computer Sciences Conferences: An Experiment with the Microsoft Academic Graph Dataset (Apr, 2016)</a></li>
<li><a href="https://dl.acm.org/citation.cfm?doid=2835776.2855119">WSDM Cup 2016: Entity Ranking Challengei (Feb, 2016)</a></li>
<li><a href="http://www.www2015.it/documents/proceedings/companion/p243.pdf">An Overview of Microsoft Academic Service (MAS) and Applications (May, 2015)</a></li>
<li><a href="http://abhie19.github.io/MS_Academic_Graph/">Citation recommendation of 80 Million papers using Graph DB(Neo-4J)</a></li>
</ul>
<h2>lquan/MicrosoftAcademicSearch: review of Microsoft Academic Search</h2>
<p><a href="https://github.com/lquan/MicrosoftAcademicSearch">https://github.com/lquan/MicrosoftAcademicSearch</a></p>
<h2>DanielDugan/MicrosoftAcademicPython</h2>
<p><a href="https://github.com/DanielDugan/MicrosoftAcademicPython">https://github.com/DanielDugan/MicrosoftAcademicPython</a></p>
<h2>mcialini/MicrosoftAcademicSearch: Determine duplicate authors from Microsoft’s massive research database</h2>
<p><a href="https://github.com/mcialini/MicrosoftAcademicSearch">https://github.com/mcialini/MicrosoftAcademicSearch</a></p>
<p>The Microsoft Academic Search is a research database which covers more than 50 million publications and over 19 million authors across a variety of domains. One of the main challenges with providing this service is caused by author-name ambiguity. There are many authors in the database which have unique IDs, but are the same author in reality. Given several csv files (most importantly Author.csv and PaperAuthor.csv), the task of this project is to determine which authors are duplicates.</p>
<p>The data mining algorithm I used in this project was extensive, and involved searching for a series of name variations of each author to see if perhaps they were listed under a nickname, or their name was misspelled. For example, one of the heuristics was to check all possible <abbr title="[object Object]">abbreviations</abbr> of a person’s name and see if that was listed under a different ID. So for John Doe Smith, the code would search for John D Smith, J Doe Smith, J D Smith, and J Smith.</p>
<p>After applying several of these heuristics, I received a 97.816% accuracy rating.</p>
<h3>Analysis Notes</h3>
<p>Code is 7 years old. Paper (PDF) is included with the Python code.</p>
<h2>coco11563/MicrosoftAcademicGraphDataMerge</h2>
<p><a href="https://github.com/coco11563/MicrosoftAcademicGraphDataMerge">https://github.com/coco11563/MicrosoftAcademicGraphDataMerge</a></p>
<h2>RapidSoftwareSolutions/Marketplace-MicrosoftAcademicSearch-Package: Discover more of what you need more quickly. Semantic search provides you with highly relevant search results from continually refreshed and extensive academic content from over 120 million publications.</h2>
<p><a href="https://github.com/RapidSoftwareSolutions/Marketplace-MicrosoftAcademicSearch-Package">https://github.com/RapidSoftwareSolutions/Marketplace-MicrosoftAcademicSearch-Package</a></p>
<h3>MicrosoftAcademicSearch Package</h3>
<p>Discover more of what you need more quickly. Semantic search provides you with   highly relevant search results from continually refreshed and extensive academic content from over 120 million publications.</p>
<ul>
<li>Domain: <a href="http://academic.research.microsoft.com/">academic.research</a></li>
<li>Credentials: key</li>
</ul>
<h3>How to get credentials:</h3>
<ol>
<li>Subscribe to the Microsoft Text Analytics API on the <a href="https://azure.microsoft.com/en-us/services/cognitive-services/">Microsoft Azure portal</a>.</li>
<li>Click create button.</li>
<li>In settings-&gt;credential section you will see apiKey (Ocp-Apim-Subscription-Key)</li>
</ol>
<h3>Analysis Notes</h3>
<p>Haven’t scanned the source code (PHP), but might be useful.</p>
<h2>DarrinEide/microsoft-academic: Documentation for all Microsoft Academic projects</h2>
<p><a href="https://github.com/DarrinEide/microsoft-academic">https://github.com/DarrinEide/microsoft-academic</a></p>
<h2>arnabsinha83/AcademicBot: Playing with Microsoft Academic API</h2>
<p><a href="https://github.com/arnabsinha83/AcademicBot">https://github.com/arnabsinha83/AcademicBot</a></p>
<h2>vwoloszyn/mag2elasticsearch: Migrating more than 160GiB of research data from Microsoft Academic Graph into an Analytics engine - Elasticsearch!</h2>
<p><a href="https://github.com/vwoloszyn/mag2elasticsearch">https://github.com/vwoloszyn/mag2elasticsearch</a></p>
<h3>Using Elasticsearch on Microsoft Academic Graph MAG</h3>
<p>Exploring more than 160 GiB of publications from Microsoft Academic Graph (MAG) using Elasticsearch!</p>
<h3>Download Microsoft Academic Graph</h3>
<p><a href="https://docs.microsoft.com/en-us/academic-services/graph/reference-data-schema">https://docs.microsoft.com/en-us/academic-services/graph/reference-data-schema</a></p>
<p><a href="https://zenodo.org/record/2628216">https://zenodo.org/record/2628216</a></p>
<pre><code>     4564007 Affiliations.txt
 16528778635 Authors.txt
     2224843 ConferenceInstances.txt
      428103 ConferenceSeries.txt
    55188690 FieldsOfStudy.txt
     5689662 Journals.txt
 40976541540 PaperAuthorAffiliations.txt
 32446006785 PaperReferences.txt
     7763592 PaperResources.txt
 60213784152 Papers.txt
 23096534376 PaperUrls.txt
 ----------------------------------------
173337504385 (~161.4) GiB
</code></pre>
<h2>hugoTO/Microsoft-Academic-Graph: Microsoft Academic Graph Guide</h2>
<p><a href="https://github.com/hugoTO/Microsoft-Academic-Graph">https://github.com/hugoTO/Microsoft-Academic-Graph</a></p>
<p>The Microsoft Academic Graph (MAG) is a heterogeneous graph containing scientific publication records, citation relationships between those publications, as well as authors, institutions, journals, conferences, and fields of study. This graph is used to power experiences in Bing, Cortana, Word, and in Microsoft Academic. The graph is currently being updated on a weekly basis.</p>
<p>In this tutorial, you are able to create a organization insights with MAG and PowerBI like this.</p>
<h2>ankeshanand/Microsoft-academic-crawler: Scripts to crawl the Microsoft academic site to create a database of research papers for building a citation network, written primarily in PHP.</h2>
<p><a href="https://github.com/ankeshanand/Microsoft-academic-crawler">https://github.com/ankeshanand/Microsoft-academic-crawler</a></p>
<h3>Analysis Notes</h3>
<p>7 years old, hence very probably obsolete.</p>
<h2>mattmarx/reliance_on_science: linkages from non-patent literature (NPL) references from USPTO patents since 1947 to academic papers since 1800 using Microsoft Academic Graph</h2>
<p><a href="https://github.com/mattmarx/reliance_on_science">https://github.com/mattmarx/reliance_on_science</a></p>
<p>The codes necessary to replicate Marx/Fuegi 2019 are contained in this directory. This code operates on, and assumes the presence of, a set of files from the Microsoft Academic Graph (MAG) and USPTO non-patent literature (NPL) references, described below.</p>
<h3>DISCLAIMERS</h3>
<p>The code is unsupported and is largely undocumented. It is provided primarily for those interested in understanding how the NPL linkages to MAG were accomplished. Moreover, it is executable only in a Sun Grid Engine (or similar) Unix environment with STATA installed as well as several packages including ftools and gtools and the Perl module Text::LevenshteinXS. It assumes the directory structure described below and contains hardcoded, fully-qualified pathnames. Moreover, you will need at least 5 terabytes of disk space, perhaps as much as 10.</p>
<p>There are four general steps in executing the matches: First, preparing the MAG data. Second, preparing the NPL data. Third, generating a first-pass set of “loose” matches. Fourth, scoring those “loose” matches and picking the best match for each NPL. Each of these major steps includes a number of sub-steps; there is no “master” script to run the process from beginning to end.</p>
<h2>lhviet/microsoft-academic-crawler: Crawling Title and Abstract information of papers from Microsoft Academic</h2>
<p><a href="https://github.com/lhviet/microsoft-academic-crawler">https://github.com/lhviet/microsoft-academic-crawler</a></p>
<h2>tczpl/BOP2016-Microsoft-Academic-Knowledge-API: Nodejs/ Microsoft Academic Knowledge API</h2>
<p><a href="https://github.com/tczpl/BOP2016-Microsoft-Academic-Knowledge-API">https://github.com/tczpl/BOP2016-Microsoft-Academic-Knowledge-API</a></p>
<p>Microsoft Beauty of Programming 2016 semi-final project</p>
<p>Use the given Microsoft Academic Search API to write a Restful API that returns all paths where the distance between two points (authors or papers) is &lt;4.</p>
<p>Because the ranking is based on response time, NodeJS asynchronous single thread is used.
After discussing ideas with teammates, I wrote the code. At the top, I was ranked in the 30s. However, I didn’t make the promotion.</p>
<h2>bethgelab/magapi-wrapper: Wrapper around Microsoft Academic Knowledge API to retrieve MAG data</h2>
<p><a href="https://github.com/bethgelab/magapi-wrapper">https://github.com/bethgelab/magapi-wrapper</a></p>
<p>Microsoft Academic knowledge provides rich API’s to retrieve information from Microsoft Academic Graph. MAG knowledge base is web-based heterogeneous entity graph which consists of entities such as Papers, Field of study, Authors, Affiliations, Citation Contexts, References etc.</p>
<p>This tool provides a wrapper around the Knowledge API to retrieve Authors, Field of Study and Papers data.</p>
<h2>Azure-Samples/microsoft-academic-knowledge-exploration-service-javascript-samples: Sample Javascript code for interacting with Microsoft Academic Knowledge Exploration Service (MAKES)</h2>
<p><a href="https://github.com/Azure-Samples/microsoft-academic-knowledge-exploration-service-javascript-samples">https://github.com/Azure-Samples/microsoft-academic-knowledge-exploration-service-javascript-samples</a></p>
<p>This sample creates a very simple webpage that leverages MAKES entity and semantic interpretation engines via javascript for searching academic papers.</p>
<h3>Microsoft Academic Knowledge Exploration Service (MAKES) Samples</h3>
<h4><a href="samples/academic-semantic-search-website/get-started.md">Academic semantic search website</a></h4>
<p>This sample creates a very simple webpage that leverages MAKES entity and semantic interpretation engines via javascript for searching academic papers.</p>
<h2>maysam/atn1</h2>
<p><a href="https://github.com/maysam/atn1">https://github.com/maysam/atn1</a></p>
<h3>Analysis Notes</h3>
<p>C# code</p>
<p>Has Microsoft Academic Search support, but I don’t see Google Scholar in there. (Done a very cursory source scan though.)</p>
<h2>supersambo/Author-Search-Msft-Academic-Search: A simple script to get publications of given authors from Microsoft Academic Search</h2>
<p><a href="https://github.com/supersambo/Author-Search-Msft-Academic-Search">https://github.com/supersambo/Author-Search-Msft-Academic-Search</a></p>
<h3>Publication search</h3>
<p>This is a very simple single purpose script to query the Microsoft Academic Search Api for publications based on a list of given author names.</p>
<p>In order to use this:</p>
<ul>
<li>Download this repository</li>
<li>Get an Api key from <a href="https://www.microsoft.com/cognitive-services/en-US/sign-up?ReturnUrl=/cognitive-services/en-us/subscriptions">here</a></li>
<li>Edit access_key.edit by filling in your own key and change the filename to access_key</li>
<li>Create a text file containing a list of authors (one per line) you want to query. Take <code>test.txt</code> as a reference if needed.</li>
<li>Run the script with the path to your input file as a command line argument e.g. like this
<code>python query_authors.py test.txt</code></li>
<li>The script will save the raw results as a single json file for each author to the <code>output/</code> directory</li>
</ul>
<hr>
<p>Note that this is everything but sophisticated and does not handle api errors.</p>
<p>If you run into API limits just stop the script and/or implement your own error handling. At least the console will tell you that there is something going wrong.</p>
<h2>wallyliu/PACInterview: Crawler of Microsoft Academic and Google Scholar implemented with python</h2>
<p><a href="https://github.com/wallyliu/PACInterview">https://github.com/wallyliu/PACInterview</a></p>
<h3>Analysis Notes</h3>
<p>From the README:</p>
<ol start="3">
<li>Google Scholar Crawler</li>
</ol>
<p>Use python to build a crawler for the following website</p>
<p>** (NOTE): This function cannot crawl target page because it will be detected as ROBOT. It only implements a parser part. **</p>
<hr>
<p>On the other hand, the code seems to include a recent Microsoft Academic Crawler but this code uses a Selenium driver to open a browser to access the site: <a href="https://github.com/wallyliu/PACInterview/blob/master/MSSpider.py#L2">https://github.com/wallyliu/PACInterview/blob/master/MSSpider.py#L2</a></p>
<h2>cfranck9/extract_article_abstract: Extract abstract of a journal article using Microsoft Academic API</h2>
<p><a href="https://github.com/cfranck9/extract_article_abstract">https://github.com/cfranck9/extract_article_abstract</a></p>
<p>A simplistic Python code to extract abstract of a single journal article using Microsoft Academic API. User can enter either title or DOI of a paper for MS database query (provide at least one of the two). DOI is converted to title through Crossref API.</p>
<h3>Analysis Notes</h3>
<p>Uses Chrome Driver to open up a browser.</p>
<h2>tranhungnghiep/CitationAnalysis: Citation Analysis on the Microsoft Academic Graph Dataset</h2>
<p><a href="https://github.com/tranhungnghiep/CitationAnalysis">https://github.com/tranhungnghiep/CitationAnalysis</a></p>
<p>Citation Analysis on the Microsoft Academic Graph Dataset</p>
<p>This contains some old code fragments for the citation analysis experiments in the past. The results were not reported formally but these codes are open sourced in case someone may find them useful. Note that the codes are old and some practices may have become outdated.</p>
<p>The codes concern the analysis and prediction of citation count of papers in a scholarly dataset, and may demonstrate two techniques:</p>
<ul>
<li>
<p>Using pandas for feature engineering on graph data, demonstrating basic pandas’ operations as well as some tricky computations on graph data.</p>
</li>
<li>
<p>Using sklearn for simple machine learning pipeline setup, with feature transforming, some simple modeling, model selection by grid search CV.</p>
</li>
</ul>
<h2>deepakmunjal15/Research-Paper-Extractor-Tool: Created a Research Paper Data Extractor Tool using Microsoft Academic API. Skills Used: Python</h2>
<p><a href="https://github.com/deepakmunjal15/Research-Paper-Extractor-Tool">https://github.com/deepakmunjal15/Research-Paper-Extractor-Tool</a></p>
<h2>michaelfaerber/makg-linking: Creating owl:sameAs <abbr title="[object Object]">links</abbr> beteen the Microsoft Academic Knowledge Graph (MAKG) and other Linked Open Data sources (OpenCitations, Wikidata, …)</h2>
<p><a href="https://github.com/michaelfaerber/makg-linking">https://github.com/michaelfaerber/makg-linking</a></p>
<h2>ben-var/VISR: Visualizing Institutional Scholar Relationships using D3.js, JavaScript, HTML, and CSS after processing 330GB of data from Microsoft Academic Graph using Hadoop and Python</h2>
<p><a href="https://github.com/ben-var/VISR">https://github.com/ben-var/VISR</a></p>
<h2>karankishinani/VISR: Visualizing Institutional Scholar Relationships using d3.js, JavaScript, HTML, and CSS after processing 330GB of data from Microsoft Academic Graph by Aminer</h2>
<p><a href="https://github.com/karankishinani/VISR">https://github.com/karankishinani/VISR</a></p>
<h2>whoyoung388/visualization-of-schools: Visualizing Institutional Scholar Relationships using D3.js, JavaScript, HTML, and CSS after processing 330GB of data from Microsoft Academic Graph using Hadoop and Python.</h2>
<p><a href="https://github.com/whoyoung388/visualization-of-schools">https://github.com/whoyoung388/visualization-of-schools</a></p>
<p>View the project live at <a href="http://whoyoung388.github.io/viz-of-schools/">whoyoung388.github.io/viz-of-schools/</a> It will take ~30s to download the data and load the graph. Press the blue “Load” button once the screen is no longer greyed out to display the graph for your selected field of study.</p>
<p>All the code for the project contained in the root directory.</p>
<p>Vizualizing the results (Visualization)</p>
<p>This project folder contains the code and the reduced dataset required to perform the analysis and visualization.</p>
<p>The clustering and preprocessing code takes an extensive amount of time and is included for reference purposes only if one desires to reperform our steps or to view how some of the code works. The original MAG file is very large (330GB) but can be freely found online. It can be found at <a href="https://aminer.org/open-academic-graph">https://aminer.org/open-academic-graph</a>.</p>
<h3>Analysis Notes</h3>
<p>I had spotted these 3 repositories, which seemed like forks, but technically are not, while they <strong>do</strong> seem to contain the same data. Probably independent github imports or some such…</p>
<h2>patwaria/pubcite: A .NET citation analyzer application for scholars. It parses citation information from Google Scholar, Microsoft Academic Research and CiteseerX to populate results.</h2>
<p><a href="https://github.com/patwaria/pubcite">https://github.com/patwaria/pubcite</a></p>
<h3>Analysis Notes</h3>
<p>7 years old code.</p>
<p>Has CAPTCHA detection and robot error report detection but otherwise looks like almost everyone else: vanilla.</p>
<p>Code is at <a href="https://github.com/patwaria/pubcite/blob/master/PubCite/PubCite/GSScraper.cs">https://github.com/patwaria/pubcite/blob/master/PubCite/PubCite/GSScraper.cs</a> and <a href="https://github.com/patwaria/pubcite/blob/master/PubCite/PubCite/GSAuthorPageScraper.cs">https://github.com/patwaria/pubcite/blob/master/PubCite/PubCite/GSAuthorPageScraper.cs</a></p>
<h2>lyeec9/EssayGenerator: Generates an essay of a specified topic and length through the use of Markov Chains, Machine Learning, and Microsoft Academic Search’sAPI.</h2>
<p><a href="https://github.com/lyeec9/EssayGenerator">https://github.com/lyeec9/EssayGenerator</a></p>
<h3>Analysis Notes</h3>
<p>Just a bit of <em>fun stuff</em> I wanted to have a look at…</p>
<h2>tobiagru/ArxivAnalyticsCluster: Tool to run analytics on top of papers from arXiv. Provides a dashboard to explore connections between papers and topics. The analytics run inside a spark cluster. The papers are enriched with the microsoft academic graph.</h2>
<p><a href="https://github.com/tobiagru/ArxivAnalyticsCluster">https://github.com/tobiagru/ArxivAnalyticsCluster</a></p>
<h2>cran/microdemic:  This is a read-only mirror of the CRAN R package repository. microdemic — ‘Microsoft Academic’ API Client. Homepage: <a href="https://github.com/ropensci/microdemic">https://github.com/ropensci/microdemic</a> (devel), <a href="https://docs.ropensci.org/microdemic">https://docs.ropensci.org/microdemic</a> (website) Report bugs for this package: <a href="https://github.com/ropensci/microdemic/issues">https://github.com/ropensci/microdemic/issues</a></h2>
<p><a href="https://github.com/cran/microdemic">https://github.com/cran/microdemic</a></p>
<h2>ninyancat13/deepfake-detection-challenge: Deepfake techniques, which present realistic AI-generated videos of people doing and saying fictional things, have the potential to have a significant impact on how people determine the legitimacy of information presented online. These content generation and modification technologies may affect the quality of public discourse and the safeguarding of human rights—especially given that deepfakes may be used maliciously as a source of misinformation, manipulation, harassment, and persuasion. Identifying manipulated media is a technically demanding and rapidly evolving challenge that requires collaborations across the entire tech industry and beyond. AWS, Facebook, Microsoft, the Partnership on AI’s Media Integrity Steering Committee, and academics have come together to build the Deepfake Detection Challenge (DFDC). The goal of the challenge is to spur researchers around the world to build innovative new technologies that can help detect deepfakes and manipulated media. - Kaggle Competiton Summary (<a href="https://www.kaggle.com/c/deepfake-detection-challenge">https://www.kaggle.com/c/deepfake-detection-challenge</a>)</h2>
<p><a href="https://github.com/ninyancat13/deepfake-detection-challenge">https://github.com/ninyancat13/deepfake-detection-challenge</a></p>
<h3>Analysis Notes</h3>
<p>Only a README, nothing else yet after 7 months!</p>
<h2>Microsoft Academic Search · timrdf/locv Wiki</h2>
<p><a href="https://github.com/timrdf/locv/wiki/Microsoft-Academic-Search">https://github.com/timrdf/locv/wiki/Microsoft-Academic-Search</a></p>
<p><a href="https://github.com/karpathy/researchlei/issues/4">https://github.com/karpathy/researchlei/issues/4</a> - Microsoft Academic Search is being retired</p>
<p>see <a href="https://github.com/karpathy/researchlei/issues/4">https://github.com/karpathy/researchlei/issues/4</a></p>
<p>Pull the citation network from:</p>
<ul>
<li>CVPR</li>
<li>ICCV</li>
<li>ECCV</li>
<li>ISWC: 360</li>
<li>IPAW: 2113</li>
<li>2242 PSSS Practical and Scalable Semantic Systems</li>
<li>3 IAWTIC International Conference on Intelligent Agents, Web Technologiesand Internet Commerce</li>
<li>46 ICWE International Conference on Web Engineering</li>
<li>49 ICWS International Conference on Web Services</li>
<li>476 WAIM Web-Age Information Management</li>
<li>487 WES Web Services, E-Business, and the Semantic Web</li>
<li>483 WebDB International Workshop on the Web and Databases</li>
<li>494 WIDM Web Information and Data Management</li>
<li>490 WI Web Intelligence</li>
<li>496 WIIW Workshop on Information Integration on the Web</li>
<li>526 WWW World Wide Web Conference Series</li>
<li>633 DIWeb Data Integration over the Web</li>
<li>1956 ESWS European Semantic Web Symposium / Conference</li>
<li>2499 SWAP Semantic Web Applications and Perspectives</li>
</ul>
<p>API User Manual</p>
<p><a href="http://academic.research.microsoft.com/About/Help.htm">http://academic.research.microsoft.com/About/Help.htm</a></p>
<p>All our APIs come with the standard 200 queries per minute.</p>
<p>Each API call returns only 100 items per call.</p>
<p>The dataset is available from <a href="https://datamarket.azure.com/dataset/mrc/microsoftacademic">https://datamarket.azure.com/dataset/mrc/microsoftacademic</a> after you sign up for an Azure account and “buy” the free subscription to the dataset.</p>
<p><a href="https://journal.code4lib.org/articles/7738">A Comparison of Article Search APIs via Blinded Experiment and Developer Review</a></p>
<h2>Citation Search · pubgem/project-guide Wiki</h2>
<p><a href="https://github.com/pubgem/project-guide/wiki/Citation-Search">https://github.com/pubgem/project-guide/wiki/Citation-Search</a></p>
<h2>Read · wikihub/eduwiki Wiki</h2>
<p><a href="https://github.com/wikihub/eduwiki/wiki/Read">https://github.com/wikihub/eduwiki/wiki/Read</a></p>
<p><a href="https://github.com/wikihub/eduwiki.wiki.git">https://github.com/wikihub/eduwiki.wiki.git</a></p>
<p>A wiki for the everyday life of students, junior and senior:</p>
<ul>
<li>Learn</li>
<li>Read</li>
<li>Watch</li>
<li>Research</li>
<li>Build</li>
<li>Code</li>
<li>Draw</li>
<li>Write</li>
<li>Present</li>
<li>Work</li>
</ul>
<p>We use MediaWiki or Markdown markup on this wiki. Here is a tutorial on editting MediaWiki pages and here, you can find the basics about Markdown.</p>
<h2>Writing in LaTeX · cognitionemotionlab/lab-docs Wiki</h2>
<p><a href="https://github.com/cognitionemotionlab/lab-docs/wiki/Writing-in-LaTeX">https://github.com/cognitionemotionlab/lab-docs/wiki/Writing-in-LaTeX</a></p>
<p><a href="https://github.com/cognitionemotionlab/lab-docs.wiki.git">https://github.com/cognitionemotionlab/lab-docs.wiki.git</a></p>
<p>This repository is built solely for the purpose of housing the Cognition &amp; Emotion Lab’s WIKI.</p>
<p>You can see the Wiki at <a href="https://github.com/cognitionemotionlab/lab-docs.wiki.git">https://github.com/cognitionemotionlab/lab-docs.wiki.git</a></p>
<p><a href="https://www.overleaf.com/learn/latex/Learn_LaTeX_in_30_minutes">https://www.overleaf.com/learn/latex/Learn_LaTeX_in_30_minutes</a></p>
<h2>acite · bavla/biblio Wiki</h2>
<p><a href="https://github.com/bavla/biblio/wiki/acite">https://github.com/bavla/biblio/wiki/acite</a></p>
<h2>Patented Foolishness · sgml/signature Wiki</h2>
<p><a href="https://github.com/sgml/signature/wiki/Patented-Foolishness">https://github.com/sgml/signature/wiki/Patented-Foolishness</a></p>
<h2>microsoft/psi - Platform for Situated Intelligence</h2>
<p><a href="https://github.com/microsoft/psi">https://github.com/microsoft/psi</a></p>
<p><strong>Platform for Situated Intelligence</strong> is an open, extensible framework that enables the development, fielding and study of multimodal, integrative-AI systems.</p>
<p>In recent years, we have seen significant progress with machine learning techniques on various perceptual and control problems. At the same time, building end-to-end, multimodal, integrative-AI systems that leverage multiple technologies and act autonomously or interact with people in the open world remains a challenging, error-prone and time-consuming engineering task. Numerous challenges stem from the sheer complexity of these systems and are amplified by the lack of appropriate infrastructure and development tools.</p>
<p>The Platform for Situated Intelligence project aims to address these issues and provide a basis for <strong>developing, fielding and studying multimodal, integrative-AI systems</strong>. The platform consists of three layers. The <strong>Runtime</strong> layer provides a parallel programming model centered around temporal streams of data, and enables easy development of components and applications using .NET, while retaining the performance properties of natively written, carefully tuned systems. A set of <strong>Tools</strong> enable multimodal data visualization, annotations, analytics, tuning and machine learning scenarios. Finally, an open ecosystem of <strong>Components</strong> encapsulate various AI technologies and allow for quick compositing of integrative-AI applications.</p>
<p>For more information about the goals of the project, the types of systems that you can build using it, and the various layers see <a href="https://github.com/microsoft/psi/wiki/Platform-Overview">Platform for Situated Intelligence Overview</a>.</p>
<h1>Using and Building</h1>
<p>Platform for Situated Intelligence is built on the .NET Framework. Large parts of it are built on .NET Standard and therefore run both on Windows and Linux, whereas some components are specific and available only to one operating system.</p>
<p>You can build applications based on Platform for Situated Intelligence either by leveraging nuget packages, or by cloning and building the code. Below are instructions:</p>
<ul>
<li><a href="https://github.com/microsoft/psi/wiki/Using-via-NuGet-Packages">Using \psi via Nuget packages</a></li>
<li><a href="https://github.com/microsoft/psi/wiki/Building-the-Codebase">Building the \psi codebase</a></li>
</ul>
<h1>Documentation and Getting Started</h1>
<p>The documentation for Platform for Situated Intelligence is available in the <a href="https://github.com/microsoft/psi/wiki">github project wiki</a>. The documentation is still under construction and in various phases of completion. If you need further explanation in any area, please open an issue and label it <code>documentation</code>, as this will help us target our documentation development efforts to the highest priority needs.</p>
<p>To learn about Platform for Situated Intelligence, we recommend you begin with the <a href="https://github.com/microsoft/psi/wiki/Brief-Introduction">Brief Introduction</a>, which provides a guided walk-through for some of the main concepts in \psi. It shows how to create a simple program, describes the core concept of a stream, and explains how to transform, synchronize, visualize, persist and replay streams from disk. We recommend that you first work through the examples in this tutorial to familiarize yourself with these core concepts.</p>
<p>In addition, a number of tutorials, samples, and other resources can help you learn more about the framework, as described below:</p>
<p><strong>Tutorials</strong>. Several <a href="https://github.com/microsoft/psi/wiki/Tutorials">tutorials</a> are available to help you get started with using Platform for Situated Intelligence. You can begin with the <a href="https://github.com/microsoft/psi/wiki/Writing-Components">Writing Components</a> tutorial, which explains how to write new \psi components, and the <a href="https://github.com/microsoft/psi/wiki/Pipeline-Execution">Pipeline-Execution</a> and <a href="https://github.com/microsoft/psi/wiki/Delivery-Policies">Delivery Policies</a> tutorials, which describe how to control the execution of pipelines and how to control throughput on streams in your application. A number of additional tutorials provide information about the set of <a href="https://github.com/microsoft/psi/wiki/Basic-Stream-Operators">basic stream operators</a> available in the framework, as well as operators for <a href="https://github.com/microsoft/psi/wiki/Stream-Fusion-and-Merging">stream fusion and merging</a>, <a href="https://github.com/microsoft/psi/wiki/Interpolation-and-Sampling">interpolation and sampling</a>, <a href="https://github.com/microsoft/psi/wiki/Windowing-Operators">windowing</a>, and <a href="https://github.com/microsoft/psi/wiki/Stream-Generators">stream generation</a>.</p>
<p><strong>Other Topics</strong>. Several documents provide information about various specialized scenarios such as running distributed applications via <a href="https://github.com/microsoft/psi/wiki/Remoting">remoting</a>, <a href="https://github.com/microsoft/psi/wiki/Interop">bridging to Python, JS, etc.</a>, <a href="https://github.com/microsoft/psi/wiki/Shared-Objects">shared objects and memory management</a>, etc.</p>
<p><strong>Samples</strong>. Besides the tutorials and other topics, it may be helpful to look through the set of <a href="https://github.com/microsoft/psi/wiki/Samples">Samples</a> provided. While some of the samples address specialized topics such as how to leverage speech recognition components or how to bridge to ROS, reading them will give you more insight into programming with \psi. In addition, some of the samples have a corresponding detailed walkthrough that explains how the samples are constructed and function, and provide further pointers to documentation and learning materials. Going through these walkthroughs can also help you learn more about programming with Platform for Situated Intelligence.</p>
<h2>manubot/rootstock: Clone me to create your Manubot manuscript</h2>
<p><a href="https://github.com/manubot/rootstock">https://github.com/manubot/rootstock</a></p>
<p>This repository is a template manuscript (a.k.a. rootstock).
Actual manuscript instances will clone this repository (see <a href="SETUP.md"><code>SETUP.md</code></a>) and replace this paragraph with a description of their manuscript.</p>
<h3>Manubot</h3>
<p>Manubot is a system for writing scholarly manuscripts via GitHub.
Manubot automates citations and references, versions manuscripts using git, and enables collaborative writing via GitHub.
An <a href="https://greenelab.github.io/meta-review/" title="Open collaborative writing with Manubot">overview manuscript</a> presents the benefits of collaborative writing with Manubot and its unique features.
The <a href="https://git.io/fhQH1">rootstock repository</a> is a general purpose template for creating new Manubot instances, as detailed in <a href="SETUP.md"><code>SETUP.md</code></a>.
See <a href="USAGE.md"><code>USAGE.md</code></a> for documentation how to write a manuscript.</p>
<h3>Analysis Notes</h3>
<p>Had picked this one as one of the off-topic “fun bits” to check out and I like it: this is very close to what I’ve been looking for when it comes to writing papers.</p>
<p>Commended. To be checked out further at a later date when there’s time for more <em>fun stuff</em>.</p>
<p><strong>Extra</strong>: check out <a href="https://github.com/bokeh/bokeh">https://github.com/bokeh/bokeh</a>, which is Python, alas. Compare to D3 et al…</p>
<h1>DOI to citation</h1>
<h2>ms609/citation-bot: Citation bot is a tool to expand and format references at Wikipedia. It retrieves citation data from a variety of sources including CrossRef (DOI), PMID, PMC and JSTOR, and returns a formatted citation. Report bugs at <a href="https://en.wikipedia.org/wiki/User_talk:Citation_bot">https://en.wikipedia.org/wiki/User_talk:Citation_bot</a></h2>
<p><a href="https://github.com/ms609/citation-bot">https://github.com/ms609/citation-bot</a></p>
<h2>Apoc2400/Reftag: Wikipedia citation tool for Google Books, New York Times, ISBN, DOI and more</h2>
<p><a href="https://github.com/Apoc2400/Reftag">https://github.com/Apoc2400/Reftag</a></p>
<h2>ropensci/handlr: convert among citation formats</h2>
<p><a href="https://github.com/ropensci/handlr">https://github.com/ropensci/handlr</a></p>
<p>a tool for converting among citation formats.</p>
<p>heavily influenced by, and code ported from <a href="https://github.com/datacite/bolognese">https://github.com/datacite/bolognese</a></p>
<p>supported readers:</p>
<ul>
<li>[citeproc][]</li>
<li>[ris][]</li>
<li>[bibtex][]</li>
<li>[codemeta][]</li>
</ul>
<p>supported writers:</p>
<ul>
<li>[citeproc][]</li>
<li>[ris][]</li>
<li>[bibtex][]</li>
<li>[<a href="http://schema.org">schema.org</a>][]</li>
<li>[rdfxml][] (requires suggested package [jsonld][])</li>
<li>[codemeta][]</li>
</ul>
<p>not supported yet, but plan to:</p>
<ul>
<li>crosscite</li>
</ul>
<h2>papis/papis: Powerful and highly extensible command-line based document and bibliography manager.</h2>
<p><a href="https://github.com/papis/papis">https://github.com/papis/papis</a></p>
<h3>Main features</h3>
<ul>
<li>Synchronizing of documents: put your documents in some folder and
synchronize it using the tools you love: git, dropbox, rsync,
OwnCloud, Google Drive … whatever.</li>
<li>Share libraries with colleagues without forcing them to open an
account, nowhere, never.</li>
<li>Download directly paper information from <em>DOI</em> number via <em>Crossref</em>.</li>
<li>(optional) <strong>scihub</strong> support, use the example papis script
<code>examples/scripts/papis-scihub</code> to download papers from scihub and
add them to your library with all the relevant information, in a
matter of seconds, also you can check the documentation
<a href="http://papis.readthedocs.io/en/latest/scihub.html">here</a>.</li>
<li>Import from Zotero and other managers using
<a href="https://github.com/papis/papis-zotero">papis-zotero</a>.</li>
<li>Create custom scripts to help you achieve great tasks easily
(<a href="http://papis.readthedocs.io/en/latest/scripting.html">doc</a>).</li>
<li>Export documents into many formats (bibtex, yaml..)</li>
<li>Command-line granularity, all the power of a library at the tip of
your fingers.</li>
</ul>
<h2>dotcs/doimgr: Command line tool using <a href="http://crossref.org">crossref.org</a>’s API to search DOIs and obtain formatted citations such as bibtex, apa, and a lot more</h2>
<p><a href="https://github.com/dotcs/doimgr">https://github.com/dotcs/doimgr</a></p>
<h2>nushio3/citation-resolve: convert document identifiers such as DOI, ISBN, arXiv ID to bibliographic reference.</h2>
<p><a href="https://github.com/nushio3/citation-resolve">https://github.com/nushio3/citation-resolve</a></p>
<p>convert document identifiers such as DOI, ISBN, arXiv ID to bibliographic reference.</p>
<h2>CrossRef/reddit-dump-experiment: Experimental extraction of DOI citation information from Reddit submission dump.</h2>
<p><a href="https://github.com/CrossRef/reddit-dump-experiment">https://github.com/CrossRef/reddit-dump-experiment</a></p>
<p>Quick analysis to look at the use of DOIs in Reddit submissions over time. Can be run locally using these instructions or on a cluster using instructions found in Spark docs.</p>
<p>Code here is a little hacky, but does the job. Suggestions welcome.</p>
<h2>foucault/citation: Generate bibtex entries from Document Object Identifiers (DOI)</h2>
<p><a href="https://github.com/foucault/citation">https://github.com/foucault/citation</a></p>
<p>citation is a dead simple Python script used to download readily formatted citations for use in bibtex just by providing its Document Object Identifier (DOI). Cut and paste the output into your .bib file and you are ready to go!</p>
<h2>haqle314/doi2citation</h2>
<p><a href="https://github.com/haqle314/doi2citation">https://github.com/haqle314/doi2citation</a></p>
<p>Just a one-liner shell script to query the API available at <a href="https://doi.org">doi.org</a> for the citation text for a DOI.</p>
<h2>Lachlan00/EasyCite: Easily download academic citation bib files and pdfs from DOIs</h2>
<p><a href="https://github.com/Lachlan00/EasyCite">https://github.com/Lachlan00/EasyCite</a></p>
<p>A simple Python script to download bibtex citations and paper PDFs. Bibtex files pulled from <a href="http://dx.doi.org/">http://dx.doi.org</a> and PDFs downloaded from SciHub using <a href="https://pypi.org/project/scidownl/">scidownl</a>.</p>
<h2>machnine/citationgen: Generate citation files from doi/pmid etc.</h2>
<p><a href="https://github.com/machnine/citationgen">https://github.com/machnine/citationgen</a></p>
<h2>kjgarza/doi-citation</h2>
<p><a href="https://github.com/kjgarza/doi-citation">https://github.com/kjgarza/doi-citation</a></p>
<h2>pierre-24/goto-publication: Citation-based URL/DOI searches</h2>
<p><a href="https://github.com/pierre-24/goto-publication">https://github.com/pierre-24/goto-publication</a></p>
<p><em>Citation-based URL/DOI searches</em>, by <code>Pierre Beaujean &lt;https://pierrebeaujean.net&gt;</code>.
CLI version of <a href="https://github.com/pierre-24/goto-publication-old/">that previous project</a>.</p>
<p>Because the journal, the volume and the page (and, sometimes, yeah, the issue) should be enough to find an article (for which, of course, you don’t have the DOI).</p>
<p>Since I have a (quantum) chemistry background, I will limit this project to the journals that are in the chemistry and physics fields.
I’m working on that, but feel free to propose <a href="https://github.com/pierre-24/goto-publication/pulls">improvements</a>.</p>
<h2>ropenscilabs/rcitoid: Citation data via Wikimedia using the Citoid service</h2>
<p><a href="https://github.com/ropenscilabs/rcitoid">https://github.com/ropenscilabs/rcitoid</a></p>
<p>Client for the Citoid service <a href="https://www.mediawiki.org/wiki/Citoid">https://www.mediawiki.org/wiki/Citoid</a></p>
<p>docs: <a href="https://en.wikipedia.org/api/rest_v1/#!/Citation/getCitation">https://en.wikipedia.org/api/rest_v1/#!/Citation/getCitation</a></p>
<h2>pierre-24/goto-publication-old: Citation-based DOI searches and redirections</h2>
<p><a href="https://github.com/pierre-24/goto-publication-old">https://github.com/pierre-24/goto-publication-old</a></p>
<p>Citation-based URL/DOI searches and redirections, by Pierre Beaujean.</p>
<p>Because the journal, the volume and the page should be enough to find an article (for which, of course, you don’t have the DOI, otherwise this is stupid).</p>
<p>Note: Since I have a (quantum) chemistry background, I will limit this project to the journals that are in the chemistry and physics fields. Feel free to fork the project if you want something else 😃</p>
<h2>gaberoo/doitex: Use doi citations in Latex and fetch automatically from CrossRef.</h2>
<p><a href="https://github.com/gaberoo/doitex">https://github.com/gaberoo/doitex</a></p>
<h2>exquisapp/CitationApp: A Node Js Application That Uses Zotero’s Translation Server To Easily Cite When Queried With Sources Like URI, DOI, ISBN, Titles …and so on.</h2>
<p><a href="https://github.com/exquisapp/CitationApp">https://github.com/exquisapp/CitationApp</a></p>
<h2>cityofaustin/doi-automation: automation for DataCite DOI citation integration with Socrata</h2>
<p><a href="https://github.com/cityofaustin/doi-automation">https://github.com/cityofaustin/doi-automation</a></p>
<p>Datacite (<a href="https://en.wikipedia.org/wiki/DataCite">https://en.wikipedia.org/wiki/DataCite</a>) is a non profit organization which provides an easy way to register, cite, and access datasets online.
The City of Austin would like to use this organization’s tools to garner insight into the usage of our open data as well as give the public a simple and effective way to cite our open data for any use.</p>
<p>To see some examples of our citations see:
<a href="https://search.datacite.org/members/austintx">https://search.datacite.org/members/austintx</a></p>
<p>This project’s goal is to explore and implement an integration between DataCite’s citation repository and the city’s Socrata Open Data portal (<a href="https://data.austintexas.gov/">https://data.austintexas.gov/</a>). This will be done by developing automation to synchronize datacite’s DOI repository with the City of Austin’s socrata portal assets and metadata using the two organization’s APIs and a python backend.</p>
<p>Socrata Discovery API:
<a href="https://socratadiscovery.docs.apiary.io/#">https://socratadiscovery.docs.apiary.io/#</a></p>
<p>DataCite REST API:
<a href="https://support.datacite.org/docs/api">https://support.datacite.org/docs/api</a></p>
<h2>dvdmrn/citation_scraper: searches pdfs for their doi and attempts to find a pubmed citation</h2>
<p><a href="https://github.com/dvdmrn/citation_scraper">https://github.com/dvdmrn/citation_scraper</a></p>
<h3>Dependencies:</h3>
<ul>
<li>Python 2</li>
<li>Scholarly (Install by opening a terminal window and typing <code>pip install scholarly</code>)</li>
<li>metapub (Install with the same method)</li>
<li>pdfminer (Install with the same method)</li>
</ul>
<h3>How to use:</h3>
<ul>
<li>Place all the unprocessed pdfs you want to analyze into the folder <code>pdfs_to_analyze</code></li>
<li>Open the program in terminal by typing <code>python citation_scraper.py</code></li>
<li>Enter the name that you would like to call your output .csv file</li>
<li>A new file will be created in the directory containing <code>citation_scraper.py</code></li>
<li>Just relax</li>
</ul>
<h2>JPFrancoia/reftool: ref2pdf returns a DOI from a formatted citation.</h2>
<p><a href="https://github.com/JPFrancoia/reftool">https://github.com/JPFrancoia/reftool</a></p>
<p>reftool is a simple script to return a DOI from a formatted citation. It can also return a direct link to download the article from Sci-Hub (this option could be illegal, use at your own risk).</p>
<p>This script uses <a href="https://doi.crossref.org/simpleTextQuery">Crossref’s Simple Text Query Tool</a>.</p>
<p>Usage is limited to 1000 requests per user/per month, and requires signing up on Crossref’s website. The script needs the email address you used to sign up.</p>
<h2>cran/citation:  This is a read-only mirror of the CRAN R package repository. citation — Software Citation Tools. Homepage: <a href="https://github.com/pik-piam/citation">https://github.com/pik-piam/citation</a>, <a href="https://doi.org/10.5281/zenodo.3813429">https://doi.org/10.5281/zenodo.3813429</a> Report bugs for this package: <a href="https://github.com/pik-piam/citation/issues">https://github.com/pik-piam/citation/issues</a></h2>
<p><a href="https://github.com/cran/citation">https://github.com/cran/citation</a></p>
<h2>ETspielberg/title2doi: A backend service to transform a list of citations to dois and further to mods via scopus</h2>
<p><a href="https://github.com/ETspielberg/title2doi">https://github.com/ETspielberg/title2doi</a></p>
<p>A small FLASK web service, taking a filename from the POST request, loads the corresponding file from the LIBINTEL_:UPLOAD_DIR directory containing an unformatted list of references.</p>
<p>each reference (= each line) is queried at the CrossRef-API to retrieve the corresponding DOI. If a DOI is found, the MyCoRe repository is queried, whether it contains the entry. In addition, Scopus is queried to retrieve the Scopus ID and actual citation counts. Results are written to the results.txt as spread sheet ascii (delimited by 😉.</p>
<h2>YutoMizutani/getdoi: A tool for getting the academic article’s DOI from citation text.</h2>
<p><a href="https://github.com/YutoMizutani/getdoi">https://github.com/YutoMizutani/getdoi</a></p>
<h2>cbosoft/bibget.py: Fetches citation data given a pdf or doi, returns in bibTeX format.</h2>
<p><a href="https://github.com/cbosoft/bibget.py">https://github.com/cbosoft/bibget.py</a></p>
<h2>joesingo/paperfinder: Script to find the DOI and BibTeX citation for a paper given it’s URL on the publisher’s website</h2>
<p><a href="https://github.com/joesingo/paperfinder">https://github.com/joesingo/paperfinder</a></p>
<p>iven a URL to a paper on a publisher’s website, find its DOI and a BibTex citation. Output can be given as plain text or JSON.</p>
<p>This takes some of the pain out of dealing with publishers’ websites. Of course, it is possible to pair this tool with SciHub to get the actual PDF (go to <a href="https://sci-hub.se/">https://sci-hub.se/</a><DOI>), but I could not possibly endorse piracy in this way…</p>
<p>Note that pf works for a very small number of publishers, and may break if publisher web pages or URLs change.</p>
<p>Supported publishers</p>
<ul>
<li>ScienceDirect</li>
<li>Springer</li>
</ul>
<h2>NANCYVALDEBENITO/articles_scopus_wos: Look for articles with scopus and web of science using python selenium. Only with DOI you can obtain affiliations, total citations, journal name and journal Rank, Journal Impact Factory … among others</h2>
<p><a href="https://github.com/NANCYVALDEBENITO/articles_scopus_wos">https://github.com/NANCYVALDEBENITO/articles_scopus_wos</a></p>
<h2>NationalLimerickProductions/seq2cite: seq2cite is a citation recommendation engine that improves upon the word of Ebisu &amp; Fang (2017) (<a href="https://dl.acm.org/doi/abs/10.1145/3077136.3080730">https://dl.acm.org/doi/abs/10.1145/3077136.3080730</a>) to recommend citations from small pieces of scientific text. We demonstrate our system with the CORD-19 dataset of articles related to COVID-19.</h2>
<p><a href="https://github.com/NationalLimerickProductions/seq2cite">https://github.com/NationalLimerickProductions/seq2cite</a></p>
<h1>keyword extraction</h1>
<h2>AimeeLee77/keyword_extraction: 利用Python实现中文文本关键词抽取，分别采用TF-IDF、TextRank、Word2Vec词聚类三种方法。</h2>
<p><a href="https://github.com/AimeeLee77/keyword_extraction">https://github.com/AimeeLee77/keyword_extraction</a></p>
<h2>bigzhao/Keyword_Extraction: 神策杯2018高校算法大师赛（中文关键词提取）第二名代码方案</h2>
<p><a href="https://github.com/bigzhao/Keyword_Extraction">https://github.com/bigzhao/Keyword_Extraction</a></p>
<h2>aneesha/RAKE: A python implementation of the Rapid Automatic Keyword Extraction</h2>
<p><a href="https://github.com/aneesha/RAKE">https://github.com/aneesha/RAKE</a></p>
<h2>LIAAD/yake: Single-document unsupervised keyword extraction</h2>
<p><a href="https://github.com/LIAAD/yake">https://github.com/LIAAD/yake</a></p>
<p>Unsupervised Approach for Automatic Keyword Extraction using Text Features.</p>
<p>YAKE! is a light-weight unsupervised automatic keyword extraction method which rests on text statistical features extracted from single documents to select the most important keywords of a text. Our system does not need to be trained on a particular set of documents, neither it depends on dictionaries, external-corpus, size of the text, language or domain. To demonstrate the merits and the significance of our proposal, we compare it against ten state-of-the-art unsupervised approaches (TF.IDF, KP-Miner, RAKE, TextRank, SingleRank, ExpandRank, TopicRank, TopicalPageRank, PositionRank and MultipartiteRank), and one supervised method (KEA). Experimental results carried out on top of twenty datasets (see Benchmark section below) show that our methods significantly outperform state-of-the-art methods under a number of collections of different sizes, languages or domains.</p>
<h3>Main Features</h3>
<ul>
<li>Unsupervised approach</li>
<li>Corpus-Independent</li>
<li>Domain and Language Independent</li>
<li>Single-Document</li>
</ul>
<h3>Benchmark</h3>
<p>YAKE!, generically outperforms, statistical methods [tf.idf (in 100% of the datasets), kp-miner (in 55%) and rake (in 100%)], state-of-the-art graph-based methods [TextRank (in 100% of the datasets), SingleRank (in 90%), TopicRank (in 70%), TopicalPageRank (in 90%), PositionRank (in 90%), MultipartiteRank (in 75%) and ExpandRank (in 100%)] and supervised learning methods [KEA (in 70% of the datasets)] across different datasets, languages and domains. The results listed in the table refer to F1 at 10 scores. Bold face marks the current best results for that specific dataset. The column “Method” cites the work of the previous (or current) best method (depending where the bold face is found). The interested reader should refer to <a href="https://github.com/LIAAD/yake/blob/master/docs/YAKEvsBaselines.jpg"><strong>this table</strong></a> in order to see a detailed comparison between YAKE and all the state-of-the-art methods.</p>
<h2>boudinfl/pke: Python Keyphrase Extraction module</h2>
<p><a href="https://github.com/boudinfl/pke">https://github.com/boudinfl/pke</a></p>
<p>pke is an open source python-based keyphrase extraction toolkit. It provides an end-to-end keyphrase extraction pipeline in which each component can be easily modified or extended to develop new models. pke also allows for easy benchmarking of state-of-the-art keyphrase extraction models, and ships with supervised models trained on the SemEval-2010 dataset.</p>
<h3>Implemented models</h3>
<p>pke currently implements the following keyphrase extraction models:</p>
<ul>
<li>Unsupervised models
<ul>
<li>Statistical models
<ul>
<li>TfIdf [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#tfidf">documentation</a>]</li>
<li>KPMiner [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#kpminer">documentation</a>, <a href="http://www.aclweb.org/anthology/S10-1041.pdf">article by (El-Beltagy and Rafea, 2010)</a>]</li>
<li>YAKE [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#yake">documentation</a>, <a href="https://doi.org/10.1016/j.ins.2019.09.013">article by (Campos et al., 2020)</a>]</li>
</ul>
</li>
<li>Graph-based models
<ul>
<li>TextRank [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#textrank">documentation</a>, <a href="http://www.aclweb.org/anthology/W04-3252.pdf">article by (Mihalcea and Tarau, 2004)</a>]</li>
<li>SingleRank  [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#singlerank">documentation</a>, <a href="http://www.aclweb.org/anthology/C08-1122.pdf">article by (Wan and Xiao, 2008)</a>]</li>
<li>TopicRank [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#topicrank">documentation</a>, <a href="http://aclweb.org/anthology/I13-1062.pdf">article by (Bougouin et al., 2013)</a>]</li>
<li>TopicalPageRank [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#topicalpagerank">documentation</a>, <a href="http://users.intec.ugent.be/cdvelder/papers/2015/sterckx2015wwwb.pdf">article by (Sterckx et al., 2015)</a>]</li>
<li>PositionRank [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#positionrank">documentation</a>, <a href="http://www.aclweb.org/anthology/P17-1102.pdf">article by (Florescu and Caragea, 2017)</a>]</li>
<li>MultipartiteRank [<a href="https://boudinfl.github.io/pke/build/html/unsupervised.html#multipartiterank">documentation</a>, <a href="https://arxiv.org/abs/1803.08721">article by (Boudin, 2018)</a>]</li>
</ul>
</li>
</ul>
</li>
<li>Supervised models
<ul>
<li>Feature-based models
<ul>
<li>Kea [<a href="https://boudinfl.github.io/pke/build/html/supervised.html#kea">documentation</a>, <a href="https://www.cs.waikato.ac.nz/ml/publications/2005/chap_Witten-et-al_Windows.pdf">article by (Witten et al., 2005)</a>]</li>
<li>WINGNUS [<a href="https://boudinfl.github.io/pke/build/html/supervised.html#wingnus">documentation</a>, <a href="http://www.aclweb.org/anthology/S10-1035.pdf">article by (Nguyen and Luong, 2010)</a>]</li>
</ul>
</li>
</ul>
</li>
</ul>
<h2>zelandiya/keyword-extraction-datasets: Different datasets for developing and testing keyword extraction algorithms</h2>
<p><a href="https://github.com/zelandiya/keyword-extraction-datasets">https://github.com/zelandiya/keyword-extraction-datasets</a></p>
<h2>ibatra/BERT-Keyword-Extractor: Deep Keyphrase Extraction using BERT</h2>
<p><a href="https://github.com/ibatra/BERT-Keyword-Extractor">https://github.com/ibatra/BERT-Keyword-Extractor</a></p>
<h2>Keyword Extraction Datasets</h2>
<p><a href="https://github.com/zelandiya/keyword-extraction-datasets">https://github.com/zelandiya/keyword-extraction-datasets</a></p>
<p>Different datasets for developing, evaluating and testing keyword extraction algorithms. For benchmarking performance see: O. Medelyan. 2009. Human-competitive automatic topic indexing. PhD Thesis. University of Waikato, New Zealand.</p>
<p>Extracting keywords using a controlled vocabulary or a thesaurus as a source:</p>
<p>NLM_500.zip - 500 PubMed documents with MeSH terms</p>
<p>fao780.tar.gz - 780 FAO publications with Agrovoc terms</p>
<p>fao30.tar.gz - 30 FAO publications, each annotated by 6 professional FAO indexers</p>
<p>Free-text keyword extraction (without a vocabulary):</p>
<p>citeulike180.tar.gz - 180 publications crawled from CiteULike, and keywords assigned by different CiteULike users who saved these publications</p>
<p>SemEval2010-Maui.zip - SemEval-2010 Keyphrase extraction track data in Maui format</p>
<p>keyphrextr.tar.gz - Keyphrase extraction model created using SemEval-2010 training data. This model is used in the Maui GPL demo when no vocabulary is selected.</p>
<p>Extracting keywords using Wikipedia as a controlled vocabulary of allowed terms:</p>
<p>wiki20.tar.gz - 20 Computer Science papers, each annotated with at least 5 Wikipedia articles by 15 teams of indexers</p>
<h2>JRC1995/TextRank-Keyword-Extraction: Keyword extraction using TextRank algorithm after pre-processing the text with lemmatization, filtering unwanted parts-of-speech and other techniques.</h2>
<p><a href="https://github.com/JRC1995/TextRank-Keyword-Extraction">https://github.com/JRC1995/TextRank-Keyword-Extraction</a></p>
<p>Based on: “TextRank: Bringing Order into Texts - by Rada Mihalcea and Paul Tarau”</p>
<h2>demoyhui/KeywordExtraction: 基于LDA和TextRank的关键子提取算法实现</h2>
<p><a href="https://github.com/demoyhui/KeywordExtraction">https://github.com/demoyhui/KeywordExtraction</a></p>
<h2>Ismael-Hery/rake-keywords: Javascript implementation of the “Rake” keywords extraction algorithm</h2>
<p><a href="https://github.com/Ismael-Hery/rake-keywords">https://github.com/Ismael-Hery/rake-keywords</a></p>
<p>Some problems with the Rake original scientific paper</p>
<p>Errors in the paper</p>
<ul>
<li>
<p>‘numbers’ is a stop word in the original Fox stop words list, thus ‘natural numbers’ can not be a candidate keywords. I removed numbers from the Fox stop list as they probably did for the paper (otherwise they would not have found ‘natural numbers’)</p>
</li>
<li>
<p>the paper does not find mixed types as a candidate keywords. I’ve added mixed types as a candidates key words</p>
</li>
<li>
<p>Non english language</p>
</li>
</ul>
<p>TODO :</p>
<ul>
<li>compute keywords from a corpus of articles (see sci paper with computation of ‘essential’ keywords)</li>
<li>French implementation with ‘mots de liaisons’ du/des/d’/… excluded from stop list</li>
</ul>
<h2>waseem18/node-rake: A NodeJS implementation of the Rapid Automatic Keyword Extraction algorithm.</h2>
<p><a href="https://github.com/waseem18/node-rake">https://github.com/waseem18/node-rake</a></p>
<h2>sleepycat/rapid-automated-keyword-extraction: A Javascript implementation of the Rapid Automated Keyword Extraction (RAKE) algorithm</h2>
<p><a href="https://github.com/sleepycat/rapid-automated-keyword-extraction">https://github.com/sleepycat/rapid-automated-keyword-extraction</a></p>
<h2>shopping24/rake-js: JS Implementation of the Rapid Automatic Keyword Extraction Paper</h2>
<p><a href="https://github.com/shopping24/rake-js">https://github.com/shopping24/rake-js</a></p>
<p>RAKE is the acronym for Rapid Automated Keyword Extraction. The basic algorithm is described by Stuart Rose, Dave Engel, Nick Cramer and Wendy Cowley in their paper “Automatic keyword extraction from individual documents” (©2010, John Wiley &amp; Sons, Ltd, Source click here).</p>
<p>In short RAKE describes splitting a text into fragments by stop words. Stop words are always considered to be irrelevant to the context. The RAKEd result of Red Zebra and Jaguar would therefore be [Red Zebra, Jaguar].</p>
<p>The score is then calculated by counting the individual words and and creating degrees based on the length of found fragments.</p>
<h3>What is this repository about?</h3>
<p>This repository includes advanced methods in addition to the original RAKE description. Furthermore we added a functional wrapper as feature for a more flexible way of handling keyword extraction. The process consists of these steps:</p>
<ul>
<li>Extracting fragments from any given text using various available methods.</li>
<li>Score the fragments.</li>
<li>Retrieve the end result.</li>
</ul>
<p>Extraction and scoring functions from any source making use of the Phrases and Phrase classes may be used and executed in the desired order.</p>
<h2>colefichter/NRake: A C# implementation of Rapid Automatic Keyword Extraction (RAKE)</h2>
<p><a href="https://github.com/colefichter/NRake">https://github.com/colefichter/NRake</a></p>
<p>This is an implementation based on the algorithm described in the paper “Automatic keyword extraction from individual documents” <a href="http://media.wiley.com/product_data/excerpt/22/04707498/0470749822.pdf">http://media.wiley.com/product_data/excerpt/22/04707498/0470749822.pdf</a>.</p>
<h2>benmcevoy/Rake: A C# implementation of the Rapid Automatic Keyword Extraction</h2>
<p><a href="https://github.com/benmcevoy/Rake">https://github.com/benmcevoy/Rake</a></p>
<h2>fromskyblue/Keywords-Extraction: Zhen Yang-Keywords Extraction</h2>
<p><a href="https://github.com/fromskyblue/Keywords-Extraction">https://github.com/fromskyblue/Keywords-Extraction</a></p>
<p>Keyword extraction by entropy difference between the intrinsic and extrinsic mode
We strive to propose a new metric to evaluate and rank the relevance of words in a text. The method uses the Shannon’s entropy difference between the intrinsic and extrinsic mode, which refers to the fact that relevant words significantly reflect the author’s writing intention, i.e., their occurrences are modulated by the author’s purpose, while the irrelevant words are distributed randomly in the text. By using The Origin of Species by Charles Darwin as a representative text sample, the performance of our detector is demonstrated and compared to previous proposals. Since a reference text ‘‘corpus’’ is all of an author’s writings, books, papers, etc. his collected works is not needed. Our approach is especially suitable for single documents of which there is no a priori information available.</p>
<h2>GomesNayagam/keyword-extraction-single-document: keyword extraction from single document, algorithm from this paper <a href="http://ymatsuo.com/papers/ijait04.pdf">http://ymatsuo.com/papers/ijait04.pdf</a></h2>
<p><a href="https://github.com/GomesNayagam/keyword-extraction-single-document">https://github.com/GomesNayagam/keyword-extraction-single-document</a></p>
<h2>ruiyuanxu/MizumotoKeywordExtraction: A keyword extration tool built for Data Structure &amp; Algorithm course.</h2>
<p><a href="https://github.com/ruiyuanxu/MizumotoKeywordExtraction">https://github.com/ruiyuanxu/MizumotoKeywordExtraction</a></p>
<p>C#</p>
<h2>ASH1998/Keyword-extraction: Keyword Extraction for PDFs</h2>
<p><a href="https://github.com/ASH1998/Keyword-extraction">https://github.com/ASH1998/Keyword-extraction</a></p>
<p>Dependencies:</p>
<ul>
<li>PyPDF2</li>
<li>sklearn</li>
<li>pandas</li>
</ul>
<p>Algorithm used</p>
<p>LDA : Linear Discriminant Analysis A classifier with a linear decision boundary, generated by fitting class conditional densities to the data and using Bayes’ rule. The model fits a Gaussian density to each class, assuming that all classes share the same covariance matrix. The fitted model can also be used to reduce the dimensionality of the input by projecting it to the most discriminative directions.</p>
<p>NMF : Non-Negative Matrix Factorization (NMF) - Find two non-negative matrices (W, H) whose product approximates the non- negative matrix X. This factorization can be used for example for dimensionality reduction, source separation or topic extraction.</p>
<h2>WuLC/KeywordExtraction: Implementation of algorithm in keyword extraction,including TextRank,TF-IDF and the combination of both</h2>
<p><a href="https://github.com/WuLC/KeywordExtraction">https://github.com/WuLC/KeywordExtraction</a></p>
<p>Implementation of serveral algorithms for keyword extraction,including TextRank,TF-IDF,TextRank along with TFTF-IDF.Cutting words and filtering stop words are relied on HanLP</p>
<h2>hankcs/HanLP: Han Language Processing</h2>
<p><a href="https://github.com/hankcs/HanLP">https://github.com/hankcs/HanLP</a></p>
<p>Natural Language Processing for the next decade. Tokenization, Part-of-Speech Tagging, Named Entity Recognition, Syntactic &amp; Semantic Dependency Parsing, Document Classification</p>
<p>The multilingual NLP library for researchers and companies, built on TensorFlow 2.0, for advancing state-of-the-art deep learning techniques in both academia and industry. HanLP was designed from day one to be efficient, user friendly and extendable. It comes with pretrained models for various human languages including English, Chinese and many others.</p>
<h2>Linguistic/rake: A Java library for Rapid Automatic Keyword Extraction (RAKE) 🍂</h2>
<p><a href="https://github.com/Linguistic/rake">https://github.com/Linguistic/rake</a></p>
<p>RAKE is an algorithm for extracting keywords (technically phrases, but I don’t question scientific literature) from a document that have a high relevance or importance to the contents of the document.</p>
<h2>sing1ee/textrank-java: a simple implementation of textrank algorithm for nlp keywords extraction</h2>
<p><a href="https://github.com/sing1ee/textrank-java">https://github.com/sing1ee/textrank-java</a></p>
<h2>ibatra/BERT-Keyword-Extractor: Deep Keyphrase Extraction using BERT</h2>
<p><a href="https://github.com/ibatra/BERT-Keyword-Extractor">https://github.com/ibatra/BERT-Keyword-Extractor</a></p>
<h2>aespresso/chinese_nlp_tutorial_clustering_keywords_extraction: 中文自然语言处理聚类与关键词提取教程</h2>
<p><a href="https://github.com/aespresso/chinese_nlp_tutorial_clustering_keywords_extraction">https://github.com/aespresso/chinese_nlp_tutorial_clustering_keywords_extraction</a></p>
<h2>BastinFlorian/Keywords_extraction_with_GOW: Graph of words (Networkx) and keywords extraction (Ktruss, Kcore, DivRank, BestCoverage)</h2>
<p><a href="https://github.com/BastinFlorian/Keywords_extraction_with_GOW">https://github.com/BastinFlorian/Keywords_extraction_with_GOW</a></p>
<ul>
<li>First we present an example of the methods used to extract keywords (see Graph of words and keywords extraction.ipynb and K-truss_code_example.ipynb)</li>
<li>Then we give a code to compute the k_core and obtain the graphs of directories of files or all files in directories containing sub-directories (see K_core_corpus.py)</li>
<li>We also give an implementation of the K-truss algorithm (see K-truss_code.py)</li>
<li>We make a time analysis to see the evolution of some words through time, in order to detect events related to them.</li>
</ul>
<h2>RHKeng/ShenCeCup: A competition on DataCastle which is about text keyword extraction ! Rank 6 / 622 !</h2>
<p><a href="https://github.com/RHKeng/ShenCeCup">https://github.com/RHKeng/ShenCeCup</a></p>
<p>A competition on DataCastle which is about text keyword extraction! Rank 6/622!</p>
<p>&quot; Shence Cup&quot; 2018 College Algorithm Masters is a single-player competition that can only be soloed by college students. Shence Data provides the titles and texts of about 100,000 news articles, of which 1,000 articles have corresponding annotation data. There are no more than 5 keywords for each article in the labeled data, and the keywords have appeared in the title or body of the article. According to the existing data, it is necessary to train a “keyword extraction” model to extract the keywords of articles without annotated data, and submit at most two keywords for each article.</p>
<p>Final ranking: 6/622</p>
<p>[…]</p>
<h3>5 Model selection</h3>
<p>Compare the effects of unsupervised models (tfidf/tfiwf, textRank, topic model LSI/LDA), and finally use tfidf as the basic model to select the keyword candidate set.</p>
<h4>5.1 The tfidf</h4>
<p>tfidf (term frequency-inverse document frequency) algorithm is a statistical method used to evaluate the importance of a word to a document set or a document in a corpus. The importance of a word increases in proportion to the number of times it appears in the document, but at the same time it decreases in inverse proportion to the frequency of its appearance in the corpus.</p>
<p>TF (term frequency) is the number of times a word appears in the article, TF (term frequency) = the number of times a word appears in the article / the total number of words in the article; IDF (inverse document frequency) is the frequency of the word , IDF reverse document frequency=log (total number of documents in the corpus/(total number of documents containing the word+1)), if a word is more common, then its denominator is larger, and the IDF value is smaller.</p>
<h4>5.2 Tfiwf</h4>
<p>TF remains unchanged, IWF is the sum of the word frequency of all words in the document/the word frequency</p>
<h4>5.3 Pagerank (listed here only to lead to the following textrank)</h4>
<p>need to know which webpages are linked to webpage A, that is, first get webpage A’s access to the chain, and then calculate webpage A’s PR by voting for webpage A from the access chain value. This design can ensure the achievement of such an effect: when some high-quality webpages point to webpage A, then the PR value of webpage A will increase because of these high-quality votes, and webpage A is pointed to by fewer webpages or by some When a web page with a lower PR value points to, the PR value of A will not be very large, which can reasonably reflect the quality level of a web page. Vi represents a certain webpage, Vj represents a webpage linked to Vi (that is, the in-link of Vi), S(Vi) represents the PR value of the webpage Vi, In(Vi) represents the collection of all in-<abbr title="[object Object]">links</abbr> of the webpage Vi, Out(Vj) Represents the number of web pages Vj linked to other web pages, and d represents the damping coefficient, which is used to overcome the inherent defects of the part after “d *” in this formula: if there is only a summation part, then the formula will not be able to handle The PR value of the web pages that enter the chain, because at this time, according to the formula, the PR value of these web pages is 0, but the actual situation is not like this, so a damping coefficient is added to ensure that each web page has a PR value greater than 0. According to the experimental results, with a damping coefficient of 0.85, the PR value can be converged to a stable value after about 100 iterations. When the damping coefficient is close to 1, the number of iterations required will increase abruptly and the sorting will be unstable. The score in front of S(Vj) in the formula refers to the PR value of Vj that should be divided equally among all the webpages pointed to by Vj, so that it can be regarded as dividing one’s votes among the webpages that one <abbr title="[object Object]">links</abbr> to.</p>
<h4>5.4 textrank</h4>
<p>is a graph-based sorting algorithm for text, which can realize keyword extraction only by using the information of a single document itself, without relying on a corpus. (Calling the interface of jieba ) Wji refers to the similarity between the two sentences of Vi and Vj. Edit distance and cosine similarity can be used. When textrank is applied to keyword extraction, it is different from automatic abstract extraction: 1) The association between words has no weight, that is, Wji is 1; 2) Each word is not linked to all words in the document, but through Set a fixed-length sliding window format, with <abbr title="[object Object]">links</abbr> between words in the window.</p>
<h4>5.5 The Topic Model</h4>
<p>topic model believes that there is no direct connection between words and documents, and that they should be connected by a dimension, which is the topic. The topic model is an automatic analysis of each document, counting the words in the document, and judging which topics the current document contains and the proportion of each topic based on the statistical information. A topic model is a generative model. Each word in an article is obtained through a process of “select a topic with a certain probability, and select a word from this topic with a certain probability”; topic models are commonly used The methods are LSI (LSA) and LDA, where LSI uses SVD (Singular Value Decomposition) for brute force cracking, while LDA uses Bayesian methods to fit distribution information. Through the LSA or LDA algorithm, you can get the distribution of the document to the topic and the distribution of the topic to the word. The distribution of the word to the topic can be obtained according to the topic to the word distribution (Bayesian method), and then through this distribution and the document to the topic distribution Calculate the similarity between the document and the word, and select the word list with high similarity as the key word of the document.</p>
<h4>5.5.1 LSA</h4>
<p>Latent Semantic Analysis (LSA), also called Latent Semantic Indexing, LSI. It is a commonly used simple topic model. LSA is a way to get the text topic based on the singular value decomposition (SVD) method. Umk represents the distribution matrix of documents to topics, and the transposition of Vnk represents the distribution matrix of topics to words. LSA uses SVD to express words and documents more essentially, and maps them to low-dimensional spaces. While limited use of text semantic information, LSA greatly reduces the cost of calculation and improves the quality of analysis. However, the computational complexity is very high, and the feature space dimension is large, and the computational efficiency is very low. When a new document enters the existing feature space, the entire space needs to be retrained to obtain the distribution information of the newly added document. In addition, there are problems of insensitivity to frequency distribution and weak physical interpretation.</p>
<h4>5.5.2 pLSA</h4>
<p>has been improved on the basis of LSA, by using the EM algorithm to fit the distribution information instead of using SVD for brute force cracking.</p>
<p>In PLSA, the bag-of-words model is also used (the bag-of-words model refers to a document. We only consider whether a word appears, regardless of the order in which it appears. On the contrary, n-gram considers the order in which the words appear). And the documents are independently exchangeable, and the words in the same document are also independently exchangeable. In PLSA, we will extract a topic word with a fixed probability, then find the corresponding word distribution according to the extracted topic word, and then extract a vocabulary according to the word distribution.</p>
<h4>5.5.3 LDA</h4>
<p>LDA is based on PLSA and adds two Dirichlet prior distributions to topic distribution and word distribution. In PLSA, both topic distribution and word distribution are uniquely determined. However, in LDA, topic distribution and word distribution are uncertain. The authors of LDA adopt Bayesian thinking and believe that they should obey a distribution. Both topic distribution and word distribution are polynomial distributions, because polynomial distributions Dirichlet distribution and Dirichlet distribution are conjugate structures. In LDA, topic distribution and word distribution use Dirichlet distribution as their conjugate prior distribution.</p>
<p>In LDA, there is no fixed optimal solution for the number of topics. When training the model, the number of topics needs to be set in advance, and the trainer needs to manually adjust the parameters according to the training results, and then optimize the number of topics. We can find the posterior distribution according to the polynomial distribution and the prior distribution of the data, and then use this posterior distribution as the next prior distribution, and iteratively update. There are generally two solving methods, the first is based on Gibbs sampling algorithm, and the second is based on variational inference EM algorithm.</p>
<h2>XuMuK1/KeywordsExtraction: Project for courses NLA and Optimization in Sk. The goal is to learn how to test different techniques for extracting keywords from news.</h2>
<p><a href="https://github.com/XuMuK1/KeywordsExtraction">https://github.com/XuMuK1/KeywordsExtraction</a></p>
<h2>pozhidaevsa/ExtractionKeywords: Extract keywords from russian text</h2>
<p><a href="https://github.com/pozhidaevsa/ExtractionKeywords">https://github.com/pozhidaevsa/ExtractionKeywords</a></p>
<h2>csurfer/rake-nltk: Python implementation of the Rapid Automatic Keyword Extraction algorithm using NLTK.</h2>
<p><a href="https://github.com/csurfer/rake-nltk">https://github.com/csurfer/rake-nltk</a></p>
<p>RAKE short for Rapid Automatic Keyword Extraction algorithm, is a domain independent keyword extraction algorithm which tries to determine key phrases in a body of text by analyzing the frequency of word appearance and its co-occurance with other words in the text.</p>
<h2>AidenHuen/SMP-Keyword-Extraction: CSDN博客的关键词提取算法，融合TF，IDF，词性，位置等多特征。该项目用于参加2017 SMP用户画像测评，排名第四,在验证集中精度为59.9%，在最终集中精度为58.7%。模型并未使用机器学习的方法，具有较强的泛化能力。</h2>
<p><a href="https://github.com/AidenHuen/SMP-Keyword-Extraction">https://github.com/AidenHuen/SMP-Keyword-Extraction</a></p>
<p>About CSDN blog keyword extraction algorithm, fusion TF, IDF, part of speech, location and other features.</p>
<p>This project was used to participate in the 2017 SMP user portrait evaluation, ranking fourth, with an accuracy of 59.9% in the verification set and 58.7% in the final set.
The model does not use machine learning methods and has strong generalization capabilities.</p>
<h2>bguvenc/keyword_extraction: Keyword extraction with Word2Vec</h2>
<p><a href="https://github.com/bguvenc/keyword_extraction">https://github.com/bguvenc/keyword_extraction</a></p>
<p>Keyword extraction method by using Word2Vec and Pagerank algorithms
The most common representation of distributional semantics is called one-hot representation in which dimensionality is equal to vocabulary’s cardinality. Elements of this vector space representation consist of 0’s and 1’s. However, this representation has some disadvantages. For example, in these representations, it is difficult to make deductions about word similarity. Due to high dimensionality, they can also cause overfitting. Moreover, it is computationally expensive.</p>
<p>Word embeddings are designed to capture attributional similarities between vocabulary items. Words that appear in similar contexts should be close to each other in the projected vector space. This means that grouping of words in a vector space must share same semantic properties. In word embeddings, Latent Semantic Analysis (LSA) uses a counting base dimensionality reduction method. Word2Vec is created as an alternative. Its low dimensionality can help to reduce computational complexity. Also compared with distributional semantics methods, it causes less overfitting. Word2Vec can also detect analogies between words.</p>
<p>Our model takes Word2Vec representations of words in a vector space. While we construct the Word2Vec model, we decide a threshold of counts of words because words that appear only once or twice in a large corpus are probably not unusual for the model, and there is not enough data to make any meaningful training on those words. A reasonable value for minimum counts changes between 0-100, and it depends on the size of corpora. Another critical parameter for Word2Vec model is the dimension of the vectors. This value changes between 100 and 400. Dimensions larger than 400 require more training but leads to more accurate models. I used Google News corpora which provided by Google which consist of 3 million word vectors. I did not remove stop words or infrequent words because these algorithms use windows and to find vector representations. So I need the nearby words to find vector representations.</p>
<p>The second step of this algorithm is to find PageRank value of each word. PageRank algorithm works with random walk. The original PageRank algorithm takes internet pages as a node. In our model PageRank algorithm takes Word2Vec representations of words. The cosine distance is used to calculate edge weights between nodes. TextRank algorithm uses a similar method. While TextRank chooses the bag of word representations of words and a different similarity measure in finding edge weights, in this algorithm I used the Word2Vec representations and the cosine similarity. After PageRank values of words are found, we can get words which have the highest PageRank values. Finally, these words can be seen as a keyword of a text.</p>
<h2>gaussic/tf-idf-keyword: Keyword extraction based on TF-IDF on specific corpus. 基于特定语料库的TF-IDF的中文关键词提取</h2>
<p><a href="https://github.com/gaussic/tf-idf-keyword">https://github.com/gaussic/tf-idf-keyword</a></p>
<p>Chinese keyword extraction</p>
<p>requirements based on TF-IDF.</p>
<h2>naushadzaman/keyword-extraction-from-tweets: keyword extraction from tweets using python</h2>
<p><a href="https://github.com/naushadzaman/keyword-extraction-from-tweets">https://github.com/naushadzaman/keyword-extraction-from-tweets</a></p>
<p>keyword extraction from tweets using python</p>
<p>In this module, we use Pattern tools to do POS tagging/Phrase extraction of tweets. The usual POS tagging/chunking tools do not work well for free form texts like tweets, so we needed to use a tool that is designed and trained for twitter/tweets. From Pattern tool output, we extract phrases as entities. You can decide to use on NP (Noun Phrase), but our default is to use NP (Noun Phrase) and ADJP (Adjective Phrase). With this tool, you can also extract hashtags, usernames, urls from the tweet.</p>
<h2>vgrabovets/multi_rake: Multilingual Rapid Automatic Keyword Extraction (RAKE) for Python</h2>
<p><a href="https://github.com/vgrabovets/multi_rake">https://github.com/vgrabovets/multi_rake</a></p>
<p>Multilingual Rapid Automatic Keyword Extraction (RAKE) for Python</p>
<p>Features</p>
<ul>
<li>Automatic keyword extraction from text written in any language</li>
<li>No need to know language of text beforehand</li>
<li>No need to have list of stopwords</li>
<li>26 languages are currently available, for the rest - stopwords are generated from provided text</li>
<li>Just configure rake, plug in text and get keywords (see implementation details)</li>
</ul>
<h2>lovit/soykeyword: Python library for keyword extraction</h2>
<p><a href="https://github.com/lovit/soykeyword">https://github.com/lovit/soykeyword</a></p>
<p>Python library for Keyword Extraction</p>
<p>Python library for keyword/association extraction. Keywords and related words extracted from by Lovit (Hyunjoong) and Hunsik Shin</p>
<p>soykeyword are defined as follows. Keywords in a set of documents are words of good quality (discriminative power) that can distinguish them from other sets of documents, and words (high coverage) that can describe them well. Words with a low frequency are more likely to appear in only one set, so they have a high level of discrimination, but weak explanation. The proposed two algorithms select words that have high explanatory and distinguishing power as keywords. An associative word defines a keyword that separates a set of documents with and without a reference word from an associative word. This also means that the word with high co-occurrence. Choose words with high co-occurrence and good explanation.</p>
<h2>tarwn/bookmark_analysis: Exploration of text analysis for automatic bookmarking/keyword extraction</h2>
<p><a href="https://github.com/tarwn/bookmark_analysis">https://github.com/tarwn/bookmark_analysis</a></p>
<p>Automated Keyword Extraction – TF-IDF, RAKE, and TextRank</p>
<p>After initially playing around with text processing in my prior post, I added an additional algorithm and cleaned up the logic to make it easier to perform test runs and reuse later. I tweaked the RAKE algorithm implementation and added TextRank into the mix, with full sample code and <abbr title="[object Object]">links</abbr> to sources available. I’m also using a read-through cache of the unprocessed and processed files so I can see the content and tweak the cleanse logic.</p>
<p>Context: The ultimate goal is to build a script that could process through 6 years of my bookmarked reading and extract out keywords, so I could do some trend analysis on how my reading has changed over time and maybe later build a supervised model with that data to analyze new online posts and produce a “worth my time or not” score.</p>
<h2>Parsely/serpextract: Easy extraction of keywords and engines from search engine results pages (SERPs).</h2>
<p><a href="https://github.com/Parsely/serpextract">https://github.com/Parsely/serpextract</a></p>
<p>serpextract provides easy extraction of keywords from search engine results pages (SERPs).</p>
<p>This module is possible in large part to the very hard work of the Piwik team. Specifically, we make extensive use of their list of search engines.</p>
<h2>singularity014/Keyword-Extraction-Bidirectional-LSTM: Deep learning LSTM + BERT based approach for labelling a corpus with keywords, then training a model to extract keywords.</h2>
<p><a href="https://github.com/singularity014/Keyword-Extraction-Bidirectional-LSTM">https://github.com/singularity014/Keyword-Extraction-Bidirectional-LSTM</a></p>
<p>Deep learning Bi-LSTM based approach for labelling a corpus with keywords, then training a model to extract keywords.</p>
<p>Article was late published in pprints.</p>
<h2>pemagrg1/Hindi-POS-Tagging-and-Keyword-Extraction: Hindi POS Tags and keywords using TNT model. Created Date: 28 Sept 2018</h2>
<p><a href="https://github.com/pemagrg1/Hindi-POS-Tagging-and-Keyword-Extraction">https://github.com/pemagrg1/Hindi-POS-Tagging-and-Keyword-Extraction</a></p>
<p>Part of speech plays a very major role in NLP task as it is important to know how a word is used in every sentences. POS tagging is used mostly for Keyword Extractions, phrase extractions, Named Entity Recognition, etc. Before going further on POS tagging, I am assuming that you all know about part of speech as we all have studied grammar during school. Didn’t we? But anyways let me give a brief explanation on it!</p>
<p>There are eight main Parts of Speech: Nouns(naming word), Pronouns(replaces a noun), Adjectives(describing word), Verbs(action word), Adverbs(describes a verb), Prepositions(shows relationships), Conjunctions(joining word) and Interjections(Expressive word). Most of it are further divided into sub-parts. Noun is divided into Proper Nouns, Common Nouns, Concrete Nouns etc.</p>
<p>Reminds you of school days?? Okay now lets start with Hindi Part of Speech Tagging.</p>
<p>Hindi Part of Speech Tagging is something that people are still doing research on as we have various techniques and libraries available for English Text and rarely for Hindi Text. <a href="https://pybliometrics.readthedocs.io/en/stable/index.html">1</a> Manish and Pushpak researched on Hindi POS using a simple HMM based POS tagger with accuracy of 93.12%. while <a href="https://github.com/OrganicIrradiation/scholarly">2</a>Nisheeth Joshi, Hemant Darbari and Iti Mathur also researched on Hindi POS using Hidden Markov Model with frequency count of two tags seen together in the corpus divided by the frequency count of the previous tag seen independently in the corpus. <a href="https://virtualenv.pypa.io/en/stable/">3</a> S Phani Kumar Gadde, Meher Vijay Yeleti used CRF based tagger and Brants TnT (Brants, 2000), a HMM based tagger for hindi POS Tag where they got an acccuracy of 94.21%.</p>
<h2>abner-wong/textrank: keyword extraction and summarization for Chinese text by TextRank</h2>
<p><a href="https://github.com/abner-wong/textrank">https://github.com/abner-wong/textrank</a></p>
<p>Based on the TextRank algorithm, the keyword extraction and summarization tasks of Chinese text are realized, and the core calculation code remains consistent with the paper.</p>
<h2>yongzhuo/Macropodus: 自然语言处理工具Macropodus，基于Albert+BiLSTM+CRF深度学习网络架构，中文分词，词性标注，命名实体识别，新词发现，关键词，文本摘要，文本相似度，科学计算器，中文数字阿拉伯数字(罗马数字)转换，中文繁简转换，拼音转换。tookit(tool) of NLP，CWS(chinese word segnment)，POS(Part-Of-Speech Tagging)，NER(name entity recognition)，Find(new words discovery)，Keyword(keyword extraction)，Summarize(text summarization)，Sim(text similarity)，Calculate(scientific calculator)，Chi2num(chinese number to arabic number)</h2>
<p><a href="https://github.com/yongzhuo/Macropodus">https://github.com/yongzhuo/Macropodus</a></p>
<p>Macropodus is a natural language processing toolkit trained on large-scale Chinese corpus based on the Albert+BiLSTM+CRF network architecture. Common NLP functions such as Chinese word segmentation, part-of-speech tagging, named entity recognition, keyword extraction, text summarization, new word discovery, text similarity, calculator, number conversion, pinyin conversion, traditional and simplified conversion will be provided.</p>
<h2>kanjirz50/rake-ja: Rapid Automatic Keyword Extraction algorithm for Japanese</h2>
<p><a href="https://github.com/kanjirz50/rake-ja">https://github.com/kanjirz50/rake-ja</a></p>
<p>Rapid Automatic Keyword Extraction algorithm for Japanese.</p>
<p>This module builds on rake-nltk.</p>
<h2>killa1218/CopyRNN-Keyword-Extraction</h2>
<p><a href="https://github.com/killa1218/CopyRNN-Keyword-Extraction">https://github.com/killa1218/CopyRNN-Keyword-Extraction</a></p>
<p>This is an implementation of Deep Keyphrase Generation based on CopyNet.</p>
<p>One training dataset (KP20k), five testing datasets (KP20k, Inspec, NUS, SemEval, Krapivin) and one pre-trained model are provided.</p>
<p>Note that the model is trained on scientific papers (abstract and keyword) in Computer Science domain, so it’s expected to work well only for CS papers.</p>
<h2>CodePothunter/keywordExtract_zh: A Chinese key terminology extraction tool for MOOC.</h2>
<p><a href="https://github.com/CodePothunter/keywordExtract_zh">https://github.com/CodePothunter/keywordExtract_zh</a></p>
<p>A Chinese key terminology extraction tool for MOOC. This tool needs to rely on the latest version of jieba for word segmentation. When using, put the entire folder in the working directory and call it as a toolkit. At present, in addition to supporting the extraction of key terms, it can also generate a summary of the lecture notes.</p>
<h2>pemagrg1/Nepali-POS-Tagging-and-Keyword-Extraction: Extract part of speech for Nepali words using TNT model. Created Date: 12 October 2018</h2>
<p><a href="https://github.com/pemagrg1/Nepali-POS-Tagging-and-Keyword-Extraction">https://github.com/pemagrg1/Nepali-POS-Tagging-and-Keyword-Extraction</a></p>
<p>Nepali is the language spoken by the people of Nepal. Nepali is actually written with the Devanagari alphabet and is an Indo-Aryan Language. The Devanagari script, which is generally known as Nagari, is written from left to right. The order of the letters made up of vowels and consonants is known as the “varnamala” which means the “garland of flowers.” In the Unicode Conventional, the Devanagari is constituted in three blocks. U+0900–U+097F comprises the Devanagari, U+1CD0–U+1CFF comprises the Devanagari Extended, and U+A8E0–U+A8FF comprises the Vedic Extension.</p>
<p>The paper, “Structure of Nepali Grammar” by Bal Krishna Bal has an awesome explanation on the grammar of Nepali <a href="https://pybliometrics.readthedocs.io/en/stable/index.html">1</a> where he explains how each part of speech is used in Nepali. Asmita (Student of Bal Krishna Bal) has also done her degree project under the guidance of Bal Krishna Bal on “Part of Speech Tagger for Nepali Text using SVM” where she got an accuracy of 88% <a href="https://github.com/OrganicIrradiation/scholarly">2</a>. Tej Bahadur Shahi,Tank Nath Dhamala, and Bikash Balami also published a paper on “Support Vector Machines based Part of Speech Tagging for Nepali Text” where they got an accuracy of 90% on TNT and 90% on SVM, using 80000 training data size<a href="https://virtualenv.pypa.io/en/stable/">3</a>.</p>
<p>Nepali and Hindi are quite similar as they both follow the Devanagari script.</p>


    <footer>
      © 2020 Qiqqa Contributors ::
      <a href="https://github.com/GerHobbelt/qiqqa-open-source/blob/docs-src/Progress in Development/Considering the Way Forward/Links to Stuff To Look At.md">Edit this page on GitHub</a>
    </footer>
  </body>
</html>