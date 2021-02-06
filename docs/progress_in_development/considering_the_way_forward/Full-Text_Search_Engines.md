<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    
    <h1>Progress in Development :: Considering the way forward : Full-Text Search Engines</h1>
<p><strong>TBD (Redact/rewrite/da worx, you know what. Make it multiple articles, now it’s only braindump)</strong></p>
<p>Forewarning: blubbering rant. Pitfall:
<a href="https://www.joelonsoftware.com/2000/04/06/things-you-should-never-do-part-i/">https://www.joelonsoftware.com/2000/04/06/things-you-should-never-do-part-i/</a></p>
<ul>
<li>you start looking when you feel agonized.
<ul>
<li>for me, it’s WPF/XAML: cute but way too verbose and hard to dive into (not just scratching the surface but getting things done in a nice looking, well-behaved way with attention to details)</li>
<li>there’s already questions about the cross-platform availability/ability of Qiqqa (<a href="https://github.com/jimmejardine/qiqqa-open-source/issues/215">#215</a>) and he’s not the only one: though I am largely Windows-based in my own work, that’s not forever and besides, I do realize that if we ever want to climb out/up that we need a Linux base at least. And <strong>I</strong> am not going to port the codebase in .NET+WPF to Linux as it is: porting WPF would mean re-doing the UI anyway as <em>there is no WPF on Linux or Apple</em> and then there were my thoughts on separating functionality (local server) from UI (local client) already from before for purposes of making UI dev work easier for me (as in: attempt moving the biatch to a well-supported cross-platform environment that I want to be in: HTML5+CSS+JS (not Qt, GTK or what-have-you – not gonna use those anywhere else, so why spend the effort on yet another UI framework I am not going to use if I can help it? Besides, go where all the action is. That’s web. Not Qt, GTK, WPF, whatever.)</li>
<li>XAML vs HTML5</li>
</ul>
</li>
</ul>
<h2>Upgrading <a href="http://Lucene.NET">Lucene.NET</a> to the bleeding edge</h2>
<p>We’ve got an old Lucene, nay, an <em>antique</em>!, and while I’m looking at the new releases via NuGet, the <a href="http://Lucene.NET">Lucene.NET</a> API has changed significantly while the documentation isn’t, how shall I put this…, isn’t exactly reaching the entirety of my brain. Nothing bad about the docs, if I was to address this, it would be a generic rant on documentation everywhere (and what’s in it) and then there’s my brain and the wondrous ability to pick some stuff up <em>fast</em> while other stuff of a similar nature sometimes just does not wish to arrive, no matter what I try. (You can start a whole philosophical evening pondering what subliminal kobold is whispering anti-thoughts in my hind-brain or what, but let’s keep the cap on that whiskey bottle while the sun is up and continue with what is more important and interesting right now: what did I do and what’s the general conclusion / sense I got out of it?</p>
<p>First off, I like to ride the bleeding edge, if possible. That requires a full library source disclosure or you’ll be in a world of hurt, so anything commercial is <em>out</em>. (Besides, we already have one example of a defunct(?) commercial dependency in Qiqqa itself: Sorax (PDF renderer) is no more.)</p>
<p>I’ve been fiddling in the wee hours, brain at half/low power, with all kinds of stuff, including the bleeding edge of <a href="http://Lucene.NET">Lucene.NET</a>.</p>
<p>Conclusion after a time of tracking it and off-branch work: (I also always look what’s happening outside the mainstream channel. RTFC and I find nice stuff often enough to keep that habit alive.)</p>
<p>It’s doing okay, seems to track the original Lucene reasonably well in terms of features, performance, etc., particularly when compared to some other ‘ports’ of Lucene (the C version, for example).</p>
<p>The bottom line question is always: is it good enough? and alive anough? It’s good enough, has a few failing tests on my box which I can’t fix (both in the mainline master and my own git merge mix line), but those test failures seem more or less benign. Though one test at least is something with the search results going the wrong way. So that’s a 7 out of 10, shall we say?</p>
<p>What spurred me into writing this (and veering off course where it comes to <a href="http://Lucene.NET">Lucene.NET</a>): I had another “great” experience with the NuGet package manager, which took an entire valuable day (instead of some dumbed down night hours) to recover from as it turned out to be unsolvable save for an <strong>entire re-install of my entire Visual Studio rig</strong>. &lt;Insert vicious scream here /&gt;</p>
<p>What that did was remind me that Visual Studio has always been a great IDE for me, but some of the bits in the dev flow (NuGet combined with how you can fiddle / edit / tweak the installed versions) still feel as convuluted as back in the day when I was doing C &amp; C++ : I could never see the sanity in the reasoning to use XML in any environment where it might be directly human-facing (me hacking project files, for example) which leaves using XML in a machinee-machine environment, which is itself insane again as it’s a huge overhead (open/close tags repeating) burdening network, lexers (parsers) and not being whitespace agnostic where it counts anyway (oh, that’s a human-facing bit there), so  the presence of any XML always was a sign of corporeal/rate insanity to me since the day it was introduced: bloody useless for both types of sender <em>and</em> receiver. Anyhooo. Some bits make me … uncomfortable.</p>
<p>One of those bits is the migration of the old Lucene API interface code to the new <a href="http://Lucene.NET">Lucene.NET</a> v4 releases / v5 bleeding edge: somehow I haven’t got around to it and that’s purely down to /hunch/ AFAICT.</p>
<p>And the hunch is this:</p>
<ul>
<li>
<p>Am I betting on the right horse, sticking with <a href="http://Lucene.NET">Lucene.NET</a>?</p>
</li>
<li>
<p>It’s been lagging behind the original more or less, has a limited user base and done in a language that’s cute (C#) and an environment that isn’t (.NET): lots happening there still, backed by Microsoft and given their installed base of applications done in it, it’s going to be alive for the foreseeable future, but it’s got that cross-platform thing going against it: .NET is very nice on Windows, but previous experience with Mono (that was a long time ago, yes) and what I read about it on the net anno 2020 AD, .NET is great outside Windows <strong>as long as you don’t want your UI to be both good looking and cross-platform portable</strong>. (The way I see it, you must invest <strong>heavily</strong> in Qt or some such on both Windows and Linux (Apple, anyone?) and then stick with it all the way to the gallows. Since the current Qiqqa UI is (a) done in WPF, which is Windows-only and <em>quite</em> someting else than Qt and friends, and (b) is still more or less intertwined with Qiqqa functionality, I’ld have a heck of a job refactoring/porting/whatever-you-name-it the bugger into a fashionable looking Qt/GTK/<em>ugh</em> thing that I would be happy to click and bang on as a user.</p>
</li>
<li>
<p>Meanwhile, all that stuff is really pre-Y2K as all the cool kids have gathered up the smart kids and some fringe kids too and make a heck of a racket over at the Webby Wonka Plant: Chrome is now, 2020 AD, the big fat winner of the browser trials (Mozilla/FF &amp; Co are still with us, but they’re becoming rather fringe, like Apple Lisa. You have FireFox because you’re a <strong>connaisseur</strong>, not a user with a mortgage and a todo list on their mind.</p>
<p>So that ekes in this subversive question: since you want to do that upgrade work, make it work smoothly again, while you’ve had a shitload of troubles with the embedded browser, which <strong>must</strong> be CEF based or you can forget about the Sniffer, period, <strong>and</strong> you get that little rash (it’s not yet frustration, but it’s close) when you try to work on the XAML/WPF side of it, why not go the whole hog and kick it off the cliff, feed it to the fishes and do the UI in JavaScript, or rather: HTML5+CSS+JS? What about it? What do we do then, uh? What are our main functionalities anyway? And what do they need done to be dragged into 2020 kicking and screaming?</p>
</li>
</ul>
<p>So <a href="http://Lucene.NET">Lucene.NET</a> is a viable candidate. That’s one.</p>
<p>What else?</p>
<p>As it’s a follower, not a leader, how about Lucene itself?</p>
<p>Well, Java is not my go-to place for fun and besides: interfacing it with a .NET codebase would ultimately come down to a local TCP connection to talk through, so whether we take Lucene or SOLR or whatever, most of the time we’ll be talking through a pipe or localhost TCP connection for front-end to back-end comms anyway. While there are interfaces done by others which don’t require that and offer a linker-or-DLL direct usage path, generally those interfaces are ill maintained, have a very reduceed user base and would require me maintaining them for Qiqqa’s sake, so the idea of a separate UI front-end isn’t all that bad / stupid after all.</p>
<p>Then what have we got elsewhere?</p>
<p>Options abound. Sphinx. ElasticSearch (which is Lucene plus a layer on top, like Solr). A few others that I’ve already forgotten when I write this, e.g.
MG4J [<a href="http://mg4j.di.unimi.it/">http://mg4j.di.unimi.it/</a>] [<a href="https://stackoverflow.com/questions/5028314/mg4j-vs-apache-lucene">https://stackoverflow.com/questions/5028314/mg4j-vs-apache-lucene</a>]
I did take a quick peek at CLucene and took to my heels immediately.</p>
<p>And then I stumble onto… PostgreSQL. Me old mate of pre-war days. My accountant is married to the elephant for many decades (nooo, that is <em>not</em> a double entendre regarding his significant other as she’s half my diameter every day of the year, I mean the <em>elephant</em>, the <strong>blue</strong> one!) and now that I look for answers in a wholly different direction some-one on the Web here tries to tell me that PostgreSQL is the answer I’m looking for?! WTF?! It’s got FTS (Full Text Search) up the wazoo while I haven’t been attentive and was oggling the gozongas of Oracle and Microsoft, and now that I’m down about 3 or 4 SO (StackOverflow) questions and have arrived at the <strong>manual</strong> (!yay!), there’s plenty to make me go “hmmmmm… might this be… viable?”</p>
<p>So I let it percolate for a bit, knowing that Qiqqa uses FTS including “highlighting” (marking) the search results in the PDF documents thanks to a customized use of Lucene where results are delivered as word+rectangle-coordinates entities when you score a hit: does PostgreSQL offer something similar?</p>
<p>Well, that’s the one bit that needs some more investigating as, yes, PostgreSQL offers hit highlighting, but looking at the manual pages and a couple of blog articles on the net, that looks like it’s only tracking word index in the text stream, while Qiqqa stores the entire page rectangle area coordinate for every word: I don’t recall <em>exactly</em> how it’s done <em>now</em>, but that’s the end result that’s required if you don’t want to loose PDF annotation features in Qiqqa anyhow.</p>
<p>Besides, there’s that bit about languages again. I am not a speaker of the language, but google Translate does wonders for me when it comes to technical papers published in it, and otherwise I’ve got some folks I might ask what the hieroglyphs mean as this analphabetic cannot read <strong>Chinese</strong>. As my prime love still is parsers (and language), Chinese and a lot of other non-Euro languages have that issue with word separation: <em>they don’t</em>. And as it happens I have several Chinise PDFs in my collection that might benefit from some proper indexing the next time around.</p>
<p>No worries, mate! Couple 'a clicks and here ya go: Pgroonga! Wut? Pgroonga! That’s an improved index type for PostgreSQL that supports Asian languages out of the box, or so the wrapper tells me, as this was done specifically for that reason by a Japanese crew. That’s close enough for me, so I go and look a little closer at the activity: it’s active, it’s not widely advertised yet but it’s young, so that might explain why Lucene is still all over the place: installed base and age. Meanwhile, someone (nay, someone<em>s</em>) are clearly very intent on making PostgreSQL FTS work for the entire globe rather than the ASCII &amp; Accents Club only, and to my mind it sounds like fun and a good thing happening.</p>
<p>Which leaves the question of local PostgreSQL databases on regular user boxes: PostgreSQL always was the Oracle-if-you-don’t-want-make-Larry-rich alternative for me, super nice (I like BIG engines and PostgreSQL always have that 12 cylinder, mucho cubico feel to me!) but that also means it’s acting (for me at least) as a <em>really serious piece of machinery</em>. Anyhoo, more checks on the webby and it looks like my support phone line won’t be heating up when I might decide to feed this to a academic / related community, even when that community is not primarily IT focused but wanting to getting a job done where IT happens to bee involved (Qiqqa). My accountant isn’t a good litmus test for that as, back in the day when that was the bee knees, he went and banged on the keyboard patching DOS batch files with the machine curiously obliging, so his jubilee with SQLedger (and PostgreSQL) is maybe not obvious but also not entirely surprising. Meanwhile Qiqqa should be doable for folks who want to use computers instead of sysadminning them, so I’ll have to testflight that one.</p>
<p>Oh! News flash! While Pgroonga looks apetizing (despite warning its users that the indexes become quite large) and I might consider moving the stuff from Sqlite to PostgreSQL (as we’d be using that one anyway and it’s the same queries more or less anyway), there’s some additional news for me as I scan the Pgroonga pages:</p>
<p>It’s an FTS like Lucene called Groonga that’s behind those fancy PostgreSQL indexes and Groonga is done in C, which is a language I dig (contrary to Java, which I … have no particular emotional relationship with (pity PCCTS turned into ANTLR and had to be done in Java, snif, but that’s about it re emotions). Intermediate conclusion: I might want to have me a little more intense look at this Groonga fella and see if we can make it swing, with or without PostgreSQL.</p>
<p>Let’s not forget about the rest of the stuff I looked at:</p>
<p>ElasticSearcch et al are nice, but they all fall into the category “interface to it using sockets or you’re toast” (i.e. either stuck with a bit ho-hum interface code repo of some kind, or you go to the real thing with a socket connect and do it all yourself anyway, now using messaging that’s at least “officially supported” by the engine makers themselves).</p>
<p>In that, they don’t differ for picking this bundle up, dropping in a PostgreSQL install, and running from there. Difference being I got a more powerful database to work with (not that qiqqa needs one) in the latter case.</p>
<p>So fundamentally there’s no obvious argument for or against any of the investigated solutions, at least not the ones I still remember here.</p>
<ul>
<li><a href="http://Lucene.NET">Lucene.NET</a>  (ABI upgrade hence code rewrite for the Qiqqa bit; it’s not nearly close enough due to the massive API changees since the days of yore)</li>
<li>Lucene : nuh-uh: sockets, baby! So that would then be:</li>
<li>Solr  (okay, I guess.)</li>
<li>ElasticSearch (<strong>not</strong> Elastic, which is a SaaS using this stuff)</li>
<li>PostgreSQL vanilla   (sorry Asia… it’ll be as crappy as before…)</li>
<li>Groonga  (cool. And I can do native interface to .NET. But…!)</li>
<li>PostgreSQL+Pgroonga (oh yeah, sockets, baby! And SQL the way I like it!)</li>
</ul>
<p>Hm. I <em>could</em> take a look at Groonga (I’m not averse to sticking my nose inside a new discovery 😃 ) but there’s a little kobold in the back of the brain yacking about .NET 32-bit, which is what Qiqqa is today by necessity: the Sorax PDF renderer (and some other commercial libs it uses) come in 32-bit flavor only. And current Qiqqa has already shown some memory issues with my own big libraries, which happen to carry a few nasty, large, PDFs, among other bits and pieces that make the system go “unnngh!”  Of course I want to move this thing to 64-bit and that’s going to happen (Sorax out, MuPDF in, for one) but still a little voice says it might be handy to keep the main functionalities a little less close together: if I want access to the document library <em>outside</em> Qiqqa, I can do that more easily when I can dig through it in SQL (now using SQLite. then PostgreSQL?) than having to script it through a EnhancedQiqqa™.</p>
<p>So it might be time-wise <em>smarter</em> to check out PostgreSQL+Pgroonga viability and mix that with the rest of the Qiqqa work.</p>
<p>After all, what are the big functionalities of Qiqqa:</p>
<ul>
<li>FTS (Full Text Search) on collected articles</li>
<li>PDF text extraction (which requires OCR for most) and indexing</li>
<li>PDF annotation (marking, text annotations, drawing/doodling)</li>
<li>PDF document reading (PDF viewer on board!)</li>
<li>BibTeX/metadata collection using Sniffer, PDF text extraction heuristics and user input</li>
<li>BibTeX / Citation management and production for MS Office and TeX/text writers.</li>
<li>document categorization (tagging)</li>
<li>document review management (rating / tagging / commenting / marking for (re)consideration)</li>
<li>document meta investigations (authors, referencing articles, …) called Expeditions</li>
</ul>
<p>What is missing from this list which I find useful too often:</p>
<ul>
<li>HTML document storage (DOM+CSS snapshot for off-line use, not URL link keeping as the page can die/disappear/get locked later)
<ul>
<li>idexing and meta-processing these just we do PDFs already: too many articles I hit are in plain HTML to not want this ability.</li>
<li>ability to view/read those documents later at any time, just like I can now with my PDFs</li>
</ul>
</li>
<li>ability to script the PDF processing: pre and post OCR, also during metadata extraction: datasheets and application notes as BibTeX types, etc.)</li>
<li>ability to batch extract / heuristically provide abstracts for documents which don’t have those in their BibTeX metadata – I’ve only observed abstracts when the metadata came from some medical sites in another format which was transformed to BibTeX)</li>
<li>more ways to get answers / work on my (meta)data. Think batch categorizing (tagging) of datasheets, ISBN number extraction of PDF books, Custom processors for anything, including literature list processing at/near the end of publications for improved linking up of documents</li>
<li>bundling multiple PDFs into a single entity: multiple published chapters form a single book</li>
<li>bundling multiple PDFs into a single ‘record’: many PDFs are encrypted/“protected” in some way which hampers viewing and printing pages: this decrypt/cleanup work can be done in batch beforehand and thus we will have the original <em>plus</em> cached derivative copies (sans waterwarks or bloody useless leader pages, for example), which are are to be attached to the same metadata as they <em>are</em> the same article (though you <em>might</em> want to mark the original different from the processed copies so they are not <em>exactly</em> aliases of one another either…</li>
<li>bundling multiple PDFs as they are various editions of the same article or book, e.g. multiple versions off arXiv, multiple versions due to multiple authors each putting up his copy with his local university masthead, plus maybe one or more magazine copies lingering on the Interwebz without an obstructing paywall, that sort of thing)</li>
</ul>
<p>What are the UI hurdles when I move away from WPF?</p>
<ul>
<li>virtual list to ensure high scroll performance when a library has 50K+ articles shown in that list</li>
<li>a PDF viewer which rather would be an image editor, where we should be able to select <em>virtual</em> text, mark such chunks of text, draw over it (and erase it if we don’t like it), annotate it with s(n)ide remarks in-flow, etc.  Currently that a custom job plus Sorax PDF to image renderer, tomorrow that could be MuPDF as renderer (very much desirable from my POV as MuPDF is also a very important part of the metadata extraction process as it is used for text extraction, etc.)</li>
<li>a Web Browser (“Sniffer”) which is able to catch all attempts to access a PDF document and download it instead, and which is able to show Google Scholar without Google making a drama about it when I want their BibTeX.</li>
</ul>
<p>What would I like to be able to do in the UI?</p>
<ul>
<li>something like Fluent.Ribbon (cute, not really needed, any decent toolbar-style approach is fine too)</li>
<li>something like Visual Studio, hence Avalon.Deck or similarly customizable where panels can be placed and stacked where we want them.</li>
<li>keyboard shortcuts to fly through this when you’re savvy</li>
<li>a nice BibTeX editor with format checking, cleanup/prettify abilities and speelchecking, please?</li>
<li>view a few graphs about the library maybe</li>
<li>do something like an Expedition or some other such graph-style (meta)data analysis on the document library.</li>
<li>view the OCR stages and the OCR result, next and maybe <em>overlayed</em> over the original. Plus ways to edit/customize the OCR and textify processes using any software I’ld like.</li>
</ul>
<p>If I change my mind and more the front-end to a cross-platform setting, that would probably become something electron-like, so then the question is: how do these wants and wishes get done in a JavaScript setting?</p>
<ul>
<li>
<p>virtual list: at least 2 folks on github did the fundamental bits for it. Then there’s also my own spreadsheet work: that grid uses virtual scroll functionality to be fast for huge numbers of rows.</p>
</li>
<li>
<p>the PDF viewer would be hairy: think of it like an image ditor maybe, where a native MuPDF is interfaced to deliver bitmaps which are drawn in a layer in the image editor. The tougher bit will be the virtual text marking I guess…</p>
</li>
<li>
<p>the embedded web browser is obvious on the one hand, but on the other we want to hook into that iframe (if Google Scholar is willing to run in an iframe anyway)… Hm…</p>
<p><a href="https://www.electronjs.org/docs/tutorial/web-embeds">https://www.electronjs.org/docs/tutorial/web-embeds</a></p>
</li>
<li>
<p>UI layout and live management is something else in JavaScript. There have been a few projects which did this, but I haven’t checked those out lately (2+ years) so I don’t know if anyone is still alive there: it’s not exactly functionality that’s in high demand by the masses (of developers)</p>
</li>
<li>
<p>D3 or similar for the graph / chart business?</p>
</li>
<li>
<p>OCR management is mostly image view + edit/markup again, at least it is as far as the front-end would be concerned.</p>
</li>
</ul>
<hr>
<p>node.js - How to use sqlite3 module with electron? - Stack Overflow
<a href="https://stackoverflow.com/questions/32504307/how-to-use-sqlite3-module-with-electron">https://stackoverflow.com/questions/32504307/how-to-use-sqlite3-module-with-electron</a></p>
<p>Node.js Native Addons and Electron 5.0 | Electron Blog
<a href="https://www.electronjs.org/blog/nodejs-native-addons-and-electron-5">https://www.electronjs.org/blog/nodejs-native-addons-and-electron-5</a></p>
<p>Building a Docking Window Management Solution in WPF - CodeProject
<a href="https://www.codeproject.com/articles/140209/building-a-docking-window-management-solution-in-w">https://www.codeproject.com/articles/140209/building-a-docking-window-management-solution-in-w</a></p>
<p>Indexing for full text search in PostgreSQL - Compose Articles
<a href="https://www.compose.com/articles/indexing-for-full-text-search-in-postgresql/">https://www.compose.com/articles/indexing-for-full-text-search-in-postgresql/</a></p>
<p>EikosPartners/windowmanagerjs: A framework to manage multiple dockable HTML windows.
<a href="https://github.com/EikosPartners/windowmanagerjs">https://github.com/EikosPartners/windowmanagerjs</a></p>
<p>dmvaldman/samsara: ☸️ Continuous UI
<a href="https://github.com/dmvaldman/samsara">https://github.com/dmvaldman/samsara</a></p>
<p>OrigenStudio/material-ui-layout: Declarative layout for Material UI
<a href="https://github.com/OrigenStudio/material-ui-layout">https://github.com/OrigenStudio/material-ui-layout</a></p>
<p>trstringer/electron-flexbox-ui-layout: Common UI layout for an Electron/React app using Flexbox
<a href="https://github.com/trstringer/electron-flexbox-ui-layout">https://github.com/trstringer/electron-flexbox-ui-layout</a></p>
<p>Bricks.js
<a href="http://callmecavs.com/bricks.js/">http://callmecavs.com/bricks.js/</a></p>
<p>callmecavs/bricks.js: A blazing fast masonry layout generator for fixed width elements.
<a href="https://github.com/callmecavs/bricks.js">https://github.com/callmecavs/bricks.js</a></p>
<p>desandro/masonry: Cascading grid layout plugin
<a href="https://github.com/desandro/masonry">https://github.com/desandro/masonry</a></p>
<p>jsPanel
<a href="https://jspanel.de/">https://jspanel.de/</a></p>
<p>Flyer53 (Stefan Sträßer)
<a href="https://github.com/Flyer53/">https://github.com/Flyer53/</a></p>
<p>Flyer53/jsPanel4: A JavaScript library to create highly configurable floating panels, modals, tooltips, hints/notifiers/alerts or contextmenus for use in backend solutions and other web applications.
<a href="https://github.com/Flyer53/jsPanel4">https://github.com/Flyer53/jsPanel4</a></p>
<p>Flyer53/jsPanel: A jQuery Plugin to create highly configurable floating panels, modals, tooltips and hints/notifiers for use in a backend solution and other web applications.
<a href="https://github.com/Flyer53/jsPanel">https://github.com/Flyer53/jsPanel</a></p>
<p>PhosphorJS: About
<a href="https://phosphorjs.github.io/about.html">https://phosphorjs.github.io/about.html</a></p>
<p>coderespawn/dock-spawn: Dock Spawn is a web based dock layout engine that aids in creating flexible user interfaces by enabling panels to be docked on the screen similar to Visual Studio IDE
<a href="https://github.com/coderespawn/dock-spawn">https://github.com/coderespawn/dock-spawn</a></p>
<p>millennialmedia/panels: A jQuery plugin for creating dockable panels in your web application
<a href="https://github.com/millennialmedia/panels">https://github.com/millennialmedia/panels</a></p>
<p>gridstack.js | Build interactive dashboards in minutes.
<a href="https://gridstackjs.com/">https://gridstackjs.com/</a></p>
<p>20+ Best Dashboard Frameworks » CSS Author
<a href="https://cssauthor.com/dashboard-frameworks/">https://cssauthor.com/dashboard-frameworks/</a></p>
<p>Tabbed panels using CSS
<a href="http://code.iamkate.com/html-and-css/tabbed-panels/">http://code.iamkate.com/html-and-css/tabbed-panels/</a></p>
<p>How to search hyphenated words in PostgreSQL full text search? - Database Administrators Stack Exchange
<a href="https://dba.stackexchange.com/questions/204588/how-to-search-hyphenated-words-in-postgresql-full-text-search/204601#204601">https://dba.stackexchange.com/questions/204588/how-to-search-hyphenated-words-in-postgresql-full-text-search/204601#204601</a></p>
<p>regex - Escape function for regular expression or LIKE patterns - Stack Overflow
<a href="https://stackoverflow.com/questions/5144036/escape-function-for-regular-expression-or-like-patterns/45741630#45741630">https://stackoverflow.com/questions/5144036/escape-function-for-regular-expression-or-like-patterns/45741630#45741630</a></p>
<p>PostgreSQL: Documentation: 12: 12.6. Dictionaries
<a href="https://www.postgresql.org/docs/current/textsearch-dictionaries.html">https://www.postgresql.org/docs/current/textsearch-dictionaries.html</a></p>
<p>PostgreSQL: Documentation: 12: 12.6. Dictionaries
<a href="https://www.postgresql.org/docs/current/textsearch-dictionaries.html#TEXTSEARCH-THESAURUS">https://www.postgresql.org/docs/current/textsearch-dictionaries.html#TEXTSEARCH-THESAURUS</a></p>
<p>postgresql - Match a phrase ending in a prefix with full text search - Stack Overflow
<a href="https://stackoverflow.com/questions/6155592/match-a-phrase-ending-in-a-prefix-with-full-text-search/41112803#41112803">https://stackoverflow.com/questions/6155592/match-a-phrase-ending-in-a-prefix-with-full-text-search/41112803#41112803</a></p>
<p>Tutorial | PGroonga
<a href="https://pgroonga.github.io/tutorial/">https://pgroonga.github.io/tutorial/</a></p>
<p>index - PostgreSQL FTS and Trigram-similarity Query Optimization - Database Administrators Stack Exchange
<a href="https://dba.stackexchange.com/questions/56224/postgresql-fts-and-trigram-similarity-query-optimization/56232#56232">https://dba.stackexchange.com/questions/56224/postgresql-fts-and-trigram-similarity-query-optimization/56232#56232</a></p>
<p>‘postgresql-performance’ tag wiki - Database Administrators Stack Exchange
<a href="https://dba.stackexchange.com/tags/postgresql-performance/info">https://dba.stackexchange.com/tags/postgresql-performance/info</a></p>
<p>sql - Are PostgreSQL column names case-sensitive? - Stack Overflow
<a href="https://stackoverflow.com/questions/20878932/are-postgresql-column-names-case-sensitive/20880247#20880247">https://stackoverflow.com/questions/20878932/are-postgresql-column-names-case-sensitive/20880247#20880247</a></p>
<p>PostgreSQL: Documentation: 12: 12.4. Additional Features
<a href="https://www.postgresql.org/docs/current/textsearch-features.html#TEXTSEARCH-QUERY-REWRITING">https://www.postgresql.org/docs/current/textsearch-features.html#TEXTSEARCH-QUERY-REWRITING</a></p>
<p>Postgresql full text search vs Solr – Charles Nagy
<a href="http://charlesnagy.info/it/postgresql/postgresql-full-text-search-vs-solr">http://charlesnagy.info/it/postgresql/postgresql-full-text-search-vs-solr</a></p>
<p>Postgres full-text search is Good Enough!
<a href="http://rachbelaid.com/postgres-full-text-search-is-good-enough/">http://rachbelaid.com/postgres-full-text-search-is-good-enough/</a></p>
<p>Types of Indexes in PostgreSQL - Highgo Software Inc.
<a href="https://www.highgo.ca/2020/06/22/types-of-indexes-in-postgresql/?utm_source=rss&amp;utm_medium=rss&amp;utm_campaign=types-of-indexes-in-postgresql">https://www.highgo.ca/2020/06/22/types-of-indexes-in-postgresql/?utm_source=rss&amp;utm_medium=rss&amp;utm_campaign=types-of-indexes-in-postgresql</a></p>
<p>PostgreSQL: Documentation: 12: Chapter 12. Full Text Search
<a href="https://www.postgresql.org/docs/current/textsearch.html">https://www.postgresql.org/docs/current/textsearch.html</a></p>
<p>Open Source Search: The Creators of Elasticsearch, ELK Stack &amp; Kibana | Elastic
<a href="https://www.elastic.co/">https://www.elastic.co/</a></p>
<p>[jira] [Commented] (LUCENE-2878) Allow Scorer to expose positions and payloads aka. nuke spans
<a href="https://mail-archives.apache.org/mod_mbox/lucene-dev/201207.mbox/%3C2061698841.73547.1342661195362.JavaMail.jiratomcat@issues-vm%3E">https://mail-archives.apache.org/mod_mbox/lucene-dev/201207.mbox/&lt;2061698841.73547.1342661195362.JavaMail.jiratomcat@issues-vm&gt;</a></p>
<p>How to add a collapsible section in markdown.
<a href="https://gist.github.com/pierrejoubert73/902cc94d79424356a8d20be2b382e1ab">https://gist.github.com/pierrejoubert73/902cc94d79424356a8d20be2b382e1ab</a></p>
<p>Redocly/redoc: 📘 OpenAPI/Swagger-generated API Reference Documentation
<a href="https://github.com/Redocly/redoc">https://github.com/Redocly/redoc</a></p>
<p>simonhaenisch/prettier-plugin-organize-imports: Make Prettier organize your imports using the TypeScript language service API.
<a href="https://github.com/simonhaenisch/prettier-plugin-organize-imports">https://github.com/simonhaenisch/prettier-plugin-organize-imports</a></p>
<p>shins/include.md at master · Mermade/shins
<a href="https://github.com/Mermade/shins/blob/master/docs/include.md">https://github.com/Mermade/shins/blob/master/docs/include.md</a></p>
<p>Mermade/widdershins: OpenAPI / Swagger, AsyncAPI &amp; Semoasa definitions to Slate / Shins compatible markdown
<a href="https://github.com/Mermade/widdershins/">https://github.com/Mermade/widdershins/</a></p>
<p>Apache Solr vs Elasticsearch: The Feature Smackdown
<a href="https://solr-vs-elasticsearch.com/">https://solr-vs-elasticsearch.com/</a>
⚠️ Pay attention / do read the notes in the section near the end called “Thoughts…”</p>
<p>Why the Apache Lucene and Solr “divorce” is better for developers and users
<a href="https://www.techrepublic.com/article/why-the-apache-lucene-and-solr-divorce-is-better-for-developers-and-users/">https://www.techrepublic.com/article/why-the-apache-lucene-and-solr-divorce-is-better-for-developers-and-users/</a></p>
<p>DB-Engines: System Properties Comparison Elasticsearch vs. Solr
<a href="https://db-engines.com/en/system/Elasticsearch%3BSolr">https://db-engines.com/en/system/Elasticsearch%3BSolr</a></p>
<p>Solr vs. Elasticsearch: Performance Differences &amp; More. How to Decide Which One is Best for You
<a href="https://sematext.com/blog/solr-vs-elasticsearch-differences/">https://sematext.com/blog/solr-vs-elasticsearch-differences/</a></p>
<p>Taking Solr to Production
<a href="https://lucene.apache.org/solr/guide/8_4/taking-solr-to-production.html">https://lucene.apache.org/solr/guide/8_4/taking-solr-to-production.html</a>
Note that both Solr and ElasticSearch have user management, etc. which are features we do not want/need. Solr, according to the sematext article above, is the one that’s more suitable for ‘static data &amp; full text search’: we are not interested in ‘log analysis’ or ‘aggregation’ that seems to be the primary use case of ElasticSearch. <a href="https://stackoverflow.com/questions/33283725/what-are-some-use-cases-for-using-elasticsearch-versus-standard-sql-queries">https://stackoverflow.com/questions/33283725/what-are-some-use-cases-for-using-elasticsearch-versus-standard-sql-queries</a> – that SO answer compares ES against classic RDBMS which is bloody obvious, while it doesn’t compare against Solr. <a href="https://www.nextbrick.com/blog/differences-between-apache-solr-and-apache-lucene/">https://www.nextbrick.com/blog/differences-between-apache-solr-and-apache-lucene/</a> <a href="https://www.nextbrick.com/blog/what-are-the-top-solr-metrics-to-monitor/">https://www.nextbrick.com/blog/what-are-the-top-solr-metrics-to-monitor/</a></p>
<p>Solr on Windows (and Linux)
<a href="https://lucene.apache.org/solr/guide/7_0/installing-solr.html">https://lucene.apache.org/solr/guide/7_0/installing-solr.html</a></p>
<p><a href="https://lucene.apache.org/solr/">https://lucene.apache.org/solr/</a>
Solr also seems to be more flexible when it comes to search plugins, but I don’t know if anyone will need those. Solr, however, is fully open-source while ElasticSearch is a little different: <a href="https://www.elastic.co/blog/doubling-down-on-open">https://www.elastic.co/blog/doubling-down-on-open</a> <a href="https://sematext.com/blog/open-distro-elasticsearch-review/">https://sematext.com/blog/open-distro-elasticsearch-review/</a> <a href="https://opendistro.github.io/for-elasticsearch/">https://opendistro.github.io/for-elasticsearch/</a> <a href="https://aws.amazon.com/blogs/opensource/keeping-open-source-open-open-distro-for-elasticsearch/">https://aws.amazon.com/blogs/opensource/keeping-open-source-open-open-distro-for-elasticsearch/</a>
<a href="https://opendistro.github.io/for-elasticsearch-docs/docs/install/windows/">https://opendistro.github.io/for-elasticsearch-docs/docs/install/windows/</a></p>
<p><a href="https://www.elastic.co/guide/en/elasticsearch/reference/current/windows.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/windows.html</a></p>
<p><a href="https://www.elastic.co/guide/en/elasticsearch/reference/current/filter-search-results.html#post-filter">https://www.elastic.co/guide/en/elasticsearch/reference/current/filter-search-results.html#post-filter</a></p>
<p><a href="https://sematext.com/guides/elasticsearch">https://sematext.com/guides/elasticsearch</a></p>
<p><a href="https://sematext.com/guides/solr/">https://sematext.com/guides/solr/</a></p>
<p><a href="https://trends.google.com/trends/explore?cat=31&amp;date=all&amp;q=lucene.net,elasticsearch%20.net">https://trends.google.com/trends/explore?cat=31&amp;date=all&amp;q=lucene.net,elasticsearch .net</a>
<a href="http://Lucene.NET">Lucene.NET</a> interest vs. <a href="http://ElasticSearch.NET">ElasticSearch.NET</a>, which is the client interface code for ElasticSearch written in C#. What you see is <a href="http://Lucene.NET">Lucene.NET</a> slowly fading to nil from 2006 to 2020 AD.
<img src="assets/google-trends-lucene.net.png" alt=""></p>
<p><a href="https://trends.google.com/trends/explore?cat=31&amp;date=all&amp;q=lucene.net,lucene,solr,elasticsearch">https://trends.google.com/trends/explore?cat=31&amp;date=all&amp;q=lucene.net,lucene,solr,elasticsearch</a>
<img src="assets/google-trends-lucene.net2.png" alt=""></p>
<p><a href="https://trends.google.com/trends/explore?cat=31&amp;date=2011-07-16%202020-08-16&amp;q=chromely,electron.net,cefglue,cefsharp,cef">https://trends.google.com/trends/explore?cat=31&amp;date=2011-07-16 2020-08-16&amp;q=chromely,electron.net,cefglue,cefsharp,cef</a>
<img src="assets/google-trends-cef-et-al1.png" alt="">
<img src="assets/google-trends-cef-et-al2.png" alt="">
If these trends are anything to go by, there’s not much interest in CEFGlue, which is cross platform, while there’s much more interest in CEFSharp, which is Windows-only. Also note that the C# CEF wrappers get much less attention than the straight C/C++ embedded browser component CEF, which is the core of Electron and several others. Now to put the C# components in perspective, here’s the trend graph with Electron included (and we drop CEFGlue to make room):
<img src="assets/google-trends-cef-et-al3.png" alt="">
and to show that we (or rather: Google) did not confuse that one with the physical entity called an electron, here’s that electron search filter redone so it’s very specific: note the correlation in the upswitng since 2014 for both, while this latter trend query of course delivers fewer hits over the entire period:
<img src="assets/google-trends-cef-et-al4.png" alt=""></p>
<p><a href="https://trends.google.com/trends/explore?cat=31&amp;date=2011-07-16%202020-08-16&amp;q=winforms,wpf%20.net,%2Fg%2F11bw_559wr,cefsharp,cef">https://trends.google.com/trends/explore?cat=31&amp;date=2011-07-16 2020-08-16&amp;q=winforms,wpf .net,%2Fg%2F11bw_559wr,cefsharp,cef</a>
<img src="assets/google-trends-cef-et-al5.png" alt="">
and redone to show that the google analystics warning there is irrelevant for this particular trend analysis: compare the <code>electron</code> curves above and below (<em>topic</em> and <em>search term</em>):
<img src="assets/google-trends-cef-et-al6.png" alt=""></p>
<p>Now that we’re comparing trends, just curious about programming languages used or to be used in Qiqqa:
<img src="assets/google-trends-cef-et-al10.png" alt="">
here Electron and CEF sink into the noise floor, while C# and JavaScript are about on par with one another, while NodeJS is making a wee bit of noise in the lowest percent range. Conclusion: it doesn’t matter all that much whether we code in C# or JavaScript, if we anticipate developer availability (that’s a rough estimate, but good enough for me right now). How about my old pals?
<a href="https://trends.google.com/trends/explore?cat=31&amp;date=2011-07-16%202020-08-16&amp;q=C%23,javascript,c%2B%2B,html,css"><img src="assets/google-trends-cef-et-al11.png" alt=""></a>
Hm, compare that with <a href="https://insights.stackoverflow.com/survey/2019">the latest SO languages vs pay grade / empoyment / interest poll</a>: it’s all mainstream, though <a href="https://insights.stackoverflow.com/survey/2019#technology-_-programming-scripting-and-markup-languages">JavaScript has the advantage</a>, or <a href="https://insights.stackoverflow.com/survey/2019#technology-_-other-frameworks-libraries-and-tools">does it? (Count .NET+.NETcore vs. NodeJS…)</a> See <a href="https://insights.stackoverflow.com/survey/2019#developer-profile-_-contributing-to-open-source">the link</a> though for an interesting tidbit: C# devs as a population are less inclined to contribute to open source, apparently. 😢🤔</p>
<p><a href="https://trends.google.com/trends/explore?cat=31&amp;date=all&amp;q=winforms,wpf%20.net,%2Fg%2F11bw_559wr,mfc%20windows,cef">https://trends.google.com/trends/explore?cat=31&amp;date=all&amp;q=winforms,wpf .net,%2Fg%2F11bw_559wr,mfc windows,cef</a>
<img src="assets/google-trends-cef-et-al12.png" alt="">
and then there’s the current year in
<img src="assets/google-trends-cef-et-al13.png" alt="">
which indicates to me that electron is sort of steady in mind’s eye, while WPF is still slowly declining – or is that wishful thinking?
Anyway, back in the day I used a few frameworks, before having to land with MFC, which I kinda liked (thanks to an MSJ article by Paul diLascia which enabled me to hack the bugger to bits) and after that it’s been a lot of <em>meh</em> (old wine, new bags) outside the HTML+CSS realm. Looks like we’re indeed heading there…</p>

  </head>
  <body>

    <h1>Progress in Development :: Considering the way forward : Full-Text Search Engines</h1>
<p><strong>TBD (Redact/rewrite/da worx, you know what. Make it multiple articles, now it’s only braindump)</strong></p>
<p>Forewarning: blubbering rant. Pitfall:
<a href="https://www.joelonsoftware.com/2000/04/06/things-you-should-never-do-part-i/">https://www.joelonsoftware.com/2000/04/06/things-you-should-never-do-part-i/</a></p>
<ul>
<li>you start looking when you feel agonized.
<ul>
<li>for me, it’s WPF/XAML: cute but way too verbose and hard to dive into (not just scratching the surface but getting things done in a nice looking, well-behaved way with attention to details)</li>
<li>there’s already questions about the cross-platform availability/ability of Qiqqa (<a href="https://github.com/jimmejardine/qiqqa-open-source/issues/215">#215</a>) and he’s not the only one: though I am largely Windows-based in my own work, that’s not forever and besides, I do realize that if we ever want to climb out/up that we need a Linux base at least. And <strong>I</strong> am not going to port the codebase in .NET+WPF to Linux as it is: porting WPF would mean re-doing the UI anyway as <em>there is no WPF on Linux or Apple</em> and then there were my thoughts on separating functionality (local server) from UI (local client) already from before for purposes of making UI dev work easier for me (as in: attempt moving the biatch to a well-supported cross-platform environment that I want to be in: HTML5+CSS+JS (not Qt, GTK or what-have-you – not gonna use those anywhere else, so why spend the effort on yet another UI framework I am not going to use if I can help it? Besides, go where all the action is. That’s web. Not Qt, GTK, WPF, whatever.)</li>
<li>XAML vs HTML5</li>
</ul>
</li>
</ul>
<h2>Upgrading <a href="http://Lucene.NET">Lucene.NET</a> to the bleeding edge</h2>
<p>We’ve got an old Lucene, nay, an <em>antique</em>!, and while I’m looking at the new releases via NuGet, the <a href="http://Lucene.NET">Lucene.NET</a> API has changed significantly while the documentation isn’t, how shall I put this…, isn’t exactly reaching the entirety of my brain. Nothing bad about the docs, if I was to address this, it would be a generic rant on documentation everywhere (and what’s in it) and then there’s my brain and the wondrous ability to pick some stuff up <em>fast</em> while other stuff of a similar nature sometimes just does not wish to arrive, no matter what I try. (You can start a whole philosophical evening pondering what subliminal kobold is whispering anti-thoughts in my hind-brain or what, but let’s keep the cap on that whiskey bottle while the sun is up and continue with what is more important and interesting right now: what did I do and what’s the general conclusion / sense I got out of it?</p>
<p>First off, I like to ride the bleeding edge, if possible. That requires a full library source disclosure or you’ll be in a world of hurt, so anything commercial is <em>out</em>. (Besides, we already have one example of a defunct(?) commercial dependency in Qiqqa itself: Sorax (PDF renderer) is no more.)</p>
<p>I’ve been fiddling in the wee hours, brain at half/low power, with all kinds of stuff, including the bleeding edge of <a href="http://Lucene.NET">Lucene.NET</a>.</p>
<p>Conclusion after a time of tracking it and off-branch work: (I also always look what’s happening outside the mainstream channel. RTFC and I find nice stuff often enough to keep that habit alive.)</p>
<p>It’s doing okay, seems to track the original Lucene reasonably well in terms of features, performance, etc., particularly when compared to some other ‘ports’ of Lucene (the C version, for example).</p>
<p>The bottom line question is always: is it good enough? and alive anough? It’s good enough, has a few failing tests on my box which I can’t fix (both in the mainline master and my own git merge mix line), but those test failures seem more or less benign. Though one test at least is something with the search results going the wrong way. So that’s a 7 out of 10, shall we say?</p>
<p>What spurred me into writing this (and veering off course where it comes to <a href="http://Lucene.NET">Lucene.NET</a>): I had another “great” experience with the NuGet package manager, which took an entire valuable day (instead of some dumbed down night hours) to recover from as it turned out to be unsolvable save for an <strong>entire re-install of my entire Visual Studio rig</strong>. &lt;Insert vicious scream here /&gt;</p>
<p>What that did was remind me that Visual Studio has always been a great IDE for me, but some of the bits in the dev flow (NuGet combined with how you can fiddle / edit / tweak the installed versions) still feel as convuluted as back in the day when I was doing C &amp; C++ : I could never see the sanity in the reasoning to use XML in any environment where it might be directly human-facing (me hacking project files, for example) which leaves using XML in a machinee-machine environment, which is itself insane again as it’s a huge overhead (open/close tags repeating) burdening network, lexers (parsers) and not being whitespace agnostic where it counts anyway (oh, that’s a human-facing bit there), so  the presence of any XML always was a sign of corporeal/rate insanity to me since the day it was introduced: bloody useless for both types of sender <em>and</em> receiver. Anyhooo. Some bits make me … uncomfortable.</p>
<p>One of those bits is the migration of the old Lucene API interface code to the new <a href="http://Lucene.NET">Lucene.NET</a> v4 releases / v5 bleeding edge: somehow I haven’t got around to it and that’s purely down to /hunch/ AFAICT.</p>
<p>And the hunch is this:</p>
<ul>
<li>
<p>Am I betting on the right horse, sticking with <a href="http://Lucene.NET">Lucene.NET</a>?</p>
</li>
<li>
<p>It’s been lagging behind the original more or less, has a limited user base and done in a language that’s cute (C#) and an environment that isn’t (.NET): lots happening there still, backed by Microsoft and given their installed base of applications done in it, it’s going to be alive for the foreseeable future, but it’s got that cross-platform thing going against it: .NET is very nice on Windows, but previous experience with Mono (that was a long time ago, yes) and what I read about it on the net anno 2020 AD, .NET is great outside Windows <strong>as long as you don’t want your UI to be both good looking and cross-platform portable</strong>. (The way I see it, you must invest <strong>heavily</strong> in Qt or some such on both Windows and Linux (Apple, anyone?) and then stick with it all the way to the gallows. Since the current Qiqqa UI is (a) done in WPF, which is Windows-only and <em>quite</em> someting else than Qt and friends, and (b) is still more or less intertwined with Qiqqa functionality, I’ld have a heck of a job refactoring/porting/whatever-you-name-it the bugger into a fashionable looking Qt/GTK/<em>ugh</em> thing that I would be happy to click and bang on as a user.</p>
</li>
<li>
<p>Meanwhile, all that stuff is really pre-Y2K as all the cool kids have gathered up the smart kids and some fringe kids too and make a heck of a racket over at the Webby Wonka Plant: Chrome is now, 2020 AD, the big fat winner of the browser trials (Mozilla/FF &amp; Co are still with us, but they’re becoming rather fringe, like Apple Lisa. You have FireFox because you’re a <strong>connaisseur</strong>, not a user with a mortgage and a todo list on their mind.</p>
<p>So that ekes in this subversive question: since you want to do that upgrade work, make it work smoothly again, while you’ve had a shitload of troubles with the embedded browser, which <strong>must</strong> be CEF based or you can forget about the Sniffer, period, <strong>and</strong> you get that little rash (it’s not yet frustration, but it’s close) when you try to work on the XAML/WPF side of it, why not go the whole hog and kick it off the cliff, feed it to the fishes and do the UI in JavaScript, or rather: HTML5+CSS+JS? What about it? What do we do then, uh? What are our main functionalities anyway? And what do they need done to be dragged into 2020 kicking and screaming?</p>
</li>
</ul>
<p>So <a href="http://Lucene.NET">Lucene.NET</a> is a viable candidate. That’s one.</p>
<p>What else?</p>
<p>As it’s a follower, not a leader, how about Lucene itself?</p>
<p>Well, Java is not my go-to place for fun and besides: interfacing it with a .NET codebase would ultimately come down to a local TCP connection to talk through, so whether we take Lucene or SOLR or whatever, most of the time we’ll be talking through a pipe or localhost TCP connection for front-end to back-end comms anyway. While there are interfaces done by others which don’t require that and offer a linker-or-DLL direct usage path, generally those interfaces are ill maintained, have a very reduceed user base and would require me maintaining them for Qiqqa’s sake, so the idea of a separate UI front-end isn’t all that bad / stupid after all.</p>
<p>Then what have we got elsewhere?</p>
<p>Options abound. Sphinx. ElasticSearch (which is Lucene plus a layer on top, like Solr). A few others that I’ve already forgotten when I write this, e.g.
MG4J [<a href="http://mg4j.di.unimi.it/">http://mg4j.di.unimi.it/</a>] [<a href="https://stackoverflow.com/questions/5028314/mg4j-vs-apache-lucene">https://stackoverflow.com/questions/5028314/mg4j-vs-apache-lucene</a>]
I did take a quick peek at CLucene and took to my heels immediately.</p>
<p>And then I stumble onto… PostgreSQL. Me old mate of pre-war days. My accountant is married to the elephant for many decades (nooo, that is <em>not</em> a double entendre regarding his significant other as she’s half my diameter every day of the year, I mean the <em>elephant</em>, the <strong>blue</strong> one!) and now that I look for answers in a wholly different direction some-one on the Web here tries to tell me that PostgreSQL is the answer I’m looking for?! WTF?! It’s got FTS (Full Text Search) up the wazoo while I haven’t been attentive and was oggling the gozongas of Oracle and Microsoft, and now that I’m down about 3 or 4 SO (StackOverflow) questions and have arrived at the <strong>manual</strong> (!yay!), there’s plenty to make me go “hmmmmm… might this be… viable?”</p>
<p>So I let it percolate for a bit, knowing that Qiqqa uses FTS including “highlighting” (marking) the search results in the PDF documents thanks to a customized use of Lucene where results are delivered as word+rectangle-coordinates entities when you score a hit: does PostgreSQL offer something similar?</p>
<p>Well, that’s the one bit that needs some more investigating as, yes, PostgreSQL offers hit highlighting, but looking at the manual pages and a couple of blog articles on the net, that looks like it’s only tracking word index in the text stream, while Qiqqa stores the entire page rectangle area coordinate for every word: I don’t recall <em>exactly</em> how it’s done <em>now</em>, but that’s the end result that’s required if you don’t want to loose PDF annotation features in Qiqqa anyhow.</p>
<p>Besides, there’s that bit about languages again. I am not a speaker of the language, but google Translate does wonders for me when it comes to technical papers published in it, and otherwise I’ve got some folks I might ask what the hieroglyphs mean as this analphabetic cannot read <strong>Chinese</strong>. As my prime love still is parsers (and language), Chinese and a lot of other non-Euro languages have that issue with word separation: <em>they don’t</em>. And as it happens I have several Chinise PDFs in my collection that might benefit from some proper indexing the next time around.</p>
<p>No worries, mate! Couple 'a clicks and here ya go: Pgroonga! Wut? Pgroonga! That’s an improved index type for PostgreSQL that supports Asian languages out of the box, or so the wrapper tells me, as this was done specifically for that reason by a Japanese crew. That’s close enough for me, so I go and look a little closer at the activity: it’s active, it’s not widely advertised yet but it’s young, so that might explain why Lucene is still all over the place: installed base and age. Meanwhile, someone (nay, someone<em>s</em>) are clearly very intent on making PostgreSQL FTS work for the entire globe rather than the ASCII &amp; Accents Club only, and to my mind it sounds like fun and a good thing happening.</p>
<p>Which leaves the question of local PostgreSQL databases on regular user boxes: PostgreSQL always was the Oracle-if-you-don’t-want-make-Larry-rich alternative for me, super nice (I like BIG engines and PostgreSQL always have that 12 cylinder, mucho cubico feel to me!) but that also means it’s acting (for me at least) as a <em>really serious piece of machinery</em>. Anyhoo, more checks on the webby and it looks like my support phone line won’t be heating up when I might decide to feed this to a academic / related community, even when that community is not primarily IT focused but wanting to getting a job done where IT happens to bee involved (Qiqqa). My accountant isn’t a good litmus test for that as, back in the day when that was the bee knees, he went and banged on the keyboard patching DOS batch files with the machine curiously obliging, so his jubilee with SQLedger (and PostgreSQL) is maybe not obvious but also not entirely surprising. Meanwhile Qiqqa should be doable for folks who want to use computers instead of sysadminning them, so I’ll have to testflight that one.</p>
<p>Oh! News flash! While Pgroonga looks apetizing (despite warning its users that the indexes become quite large) and I might consider moving the stuff from Sqlite to PostgreSQL (as we’d be using that one anyway and it’s the same queries more or less anyway), there’s some additional news for me as I scan the Pgroonga pages:</p>
<p>It’s an FTS like Lucene called Groonga that’s behind those fancy PostgreSQL indexes and Groonga is done in C, which is a language I dig (contrary to Java, which I … have no particular emotional relationship with (pity PCCTS turned into ANTLR and had to be done in Java, snif, but that’s about it re emotions). Intermediate conclusion: I might want to have me a little more intense look at this Groonga fella and see if we can make it swing, with or without PostgreSQL.</p>
<p>Let’s not forget about the rest of the stuff I looked at:</p>
<p>ElasticSearcch et al are nice, but they all fall into the category “interface to it using sockets or you’re toast” (i.e. either stuck with a bit ho-hum interface code repo of some kind, or you go to the real thing with a socket connect and do it all yourself anyway, now using messaging that’s at least “officially supported” by the engine makers themselves).</p>
<p>In that, they don’t differ for picking this bundle up, dropping in a PostgreSQL install, and running from there. Difference being I got a more powerful database to work with (not that qiqqa needs one) in the latter case.</p>
<p>So fundamentally there’s no obvious argument for or against any of the investigated solutions, at least not the ones I still remember here.</p>
<ul>
<li><a href="http://Lucene.NET">Lucene.NET</a>  (ABI upgrade hence code rewrite for the Qiqqa bit; it’s not nearly close enough due to the massive API changees since the days of yore)</li>
<li>Lucene : nuh-uh: sockets, baby! So that would then be:</li>
<li>Solr  (okay, I guess.)</li>
<li>ElasticSearch (<strong>not</strong> Elastic, which is a SaaS using this stuff)</li>
<li>PostgreSQL vanilla   (sorry Asia… it’ll be as crappy as before…)</li>
<li>Groonga  (cool. And I can do native interface to .NET. But…!)</li>
<li>PostgreSQL+Pgroonga (oh yeah, sockets, baby! And SQL the way I like it!)</li>
</ul>
<p>Hm. I <em>could</em> take a look at Groonga (I’m not averse to sticking my nose inside a new discovery 😃 ) but there’s a little kobold in the back of the brain yacking about .NET 32-bit, which is what Qiqqa is today by necessity: the Sorax PDF renderer (and some other commercial libs it uses) come in 32-bit flavor only. And current Qiqqa has already shown some memory issues with my own big libraries, which happen to carry a few nasty, large, PDFs, among other bits and pieces that make the system go “unnngh!”  Of course I want to move this thing to 64-bit and that’s going to happen (Sorax out, MuPDF in, for one) but still a little voice says it might be handy to keep the main functionalities a little less close together: if I want access to the document library <em>outside</em> Qiqqa, I can do that more easily when I can dig through it in SQL (now using SQLite. then PostgreSQL?) than having to script it through a EnhancedQiqqa™.</p>
<p>So it might be time-wise <em>smarter</em> to check out PostgreSQL+Pgroonga viability and mix that with the rest of the Qiqqa work.</p>
<p>After all, what are the big functionalities of Qiqqa:</p>
<ul>
<li>FTS (Full Text Search) on collected articles</li>
<li>PDF text extraction (which requires OCR for most) and indexing</li>
<li>PDF annotation (marking, text annotations, drawing/doodling)</li>
<li>PDF document reading (PDF viewer on board!)</li>
<li>BibTeX/metadata collection using Sniffer, PDF text extraction heuristics and user input</li>
<li>BibTeX / Citation management and production for MS Office and TeX/text writers.</li>
<li>document categorization (tagging)</li>
<li>document review management (rating / tagging / commenting / marking for (re)consideration)</li>
<li>document meta investigations (authors, referencing articles, …) called Expeditions</li>
</ul>
<p>What is missing from this list which I find useful too often:</p>
<ul>
<li>HTML document storage (DOM+CSS snapshot for off-line use, not URL link keeping as the page can die/disappear/get locked later)
<ul>
<li>idexing and meta-processing these just we do PDFs already: too many articles I hit are in plain HTML to not want this ability.</li>
<li>ability to view/read those documents later at any time, just like I can now with my PDFs</li>
</ul>
</li>
<li>ability to script the PDF processing: pre and post OCR, also during metadata extraction: datasheets and application notes as BibTeX types, etc.)</li>
<li>ability to batch extract / heuristically provide abstracts for documents which don’t have those in their BibTeX metadata – I’ve only observed abstracts when the metadata came from some medical sites in another format which was transformed to BibTeX)</li>
<li>more ways to get answers / work on my (meta)data. Think batch categorizing (tagging) of datasheets, ISBN number extraction of PDF books, Custom processors for anything, including literature list processing at/near the end of publications for improved linking up of documents</li>
<li>bundling multiple PDFs into a single entity: multiple published chapters form a single book</li>
<li>bundling multiple PDFs into a single ‘record’: many PDFs are encrypted/“protected” in some way which hampers viewing and printing pages: this decrypt/cleanup work can be done in batch beforehand and thus we will have the original <em>plus</em> cached derivative copies (sans waterwarks or bloody useless leader pages, for example), which are are to be attached to the same metadata as they <em>are</em> the same article (though you <em>might</em> want to mark the original different from the processed copies so they are not <em>exactly</em> aliases of one another either…</li>
<li>bundling multiple PDFs as they are various editions of the same article or book, e.g. multiple versions off arXiv, multiple versions due to multiple authors each putting up his copy with his local university masthead, plus maybe one or more magazine copies lingering on the Interwebz without an obstructing paywall, that sort of thing)</li>
</ul>
<p>What are the UI hurdles when I move away from WPF?</p>
<ul>
<li>virtual list to ensure high scroll performance when a library has 50K+ articles shown in that list</li>
<li>a PDF viewer which rather would be an image editor, where we should be able to select <em>virtual</em> text, mark such chunks of text, draw over it (and erase it if we don’t like it), annotate it with s(n)ide remarks in-flow, etc.  Currently that a custom job plus Sorax PDF to image renderer, tomorrow that could be MuPDF as renderer (very much desirable from my POV as MuPDF is also a very important part of the metadata extraction process as it is used for text extraction, etc.)</li>
<li>a Web Browser (“Sniffer”) which is able to catch all attempts to access a PDF document and download it instead, and which is able to show Google Scholar without Google making a drama about it when I want their BibTeX.</li>
</ul>
<p>What would I like to be able to do in the UI?</p>
<ul>
<li>something like Fluent.Ribbon (cute, not really needed, any decent toolbar-style approach is fine too)</li>
<li>something like Visual Studio, hence Avalon.Deck or similarly customizable where panels can be placed and stacked where we want them.</li>
<li>keyboard shortcuts to fly through this when you’re savvy</li>
<li>a nice BibTeX editor with format checking, cleanup/prettify abilities and speelchecking, please?</li>
<li>view a few graphs about the library maybe</li>
<li>do something like an Expedition or some other such graph-style (meta)data analysis on the document library.</li>
<li>view the OCR stages and the OCR result, next and maybe <em>overlayed</em> over the original. Plus ways to edit/customize the OCR and textify processes using any software I’ld like.</li>
</ul>
<p>If I change my mind and more the front-end to a cross-platform setting, that would probably become something electron-like, so then the question is: how do these wants and wishes get done in a JavaScript setting?</p>
<ul>
<li>
<p>virtual list: at least 2 folks on github did the fundamental bits for it. Then there’s also my own spreadsheet work: that grid uses virtual scroll functionality to be fast for huge numbers of rows.</p>
</li>
<li>
<p>the PDF viewer would be hairy: think of it like an image ditor maybe, where a native MuPDF is interfaced to deliver bitmaps which are drawn in a layer in the image editor. The tougher bit will be the virtual text marking I guess…</p>
</li>
<li>
<p>the embedded web browser is obvious on the one hand, but on the other we want to hook into that iframe (if Google Scholar is willing to run in an iframe anyway)… Hm…</p>
<p><a href="https://www.electronjs.org/docs/tutorial/web-embeds">https://www.electronjs.org/docs/tutorial/web-embeds</a></p>
</li>
<li>
<p>UI layout and live management is something else in JavaScript. There have been a few projects which did this, but I haven’t checked those out lately (2+ years) so I don’t know if anyone is still alive there: it’s not exactly functionality that’s in high demand by the masses (of developers)</p>
</li>
<li>
<p>D3 or similar for the graph / chart business?</p>
</li>
<li>
<p>OCR management is mostly image view + edit/markup again, at least it is as far as the front-end would be concerned.</p>
</li>
</ul>
<hr>
<p>node.js - How to use sqlite3 module with electron? - Stack Overflow
<a href="https://stackoverflow.com/questions/32504307/how-to-use-sqlite3-module-with-electron">https://stackoverflow.com/questions/32504307/how-to-use-sqlite3-module-with-electron</a></p>
<p>Node.js Native Addons and Electron 5.0 | Electron Blog
<a href="https://www.electronjs.org/blog/nodejs-native-addons-and-electron-5">https://www.electronjs.org/blog/nodejs-native-addons-and-electron-5</a></p>
<p>Building a Docking Window Management Solution in WPF - CodeProject
<a href="https://www.codeproject.com/articles/140209/building-a-docking-window-management-solution-in-w">https://www.codeproject.com/articles/140209/building-a-docking-window-management-solution-in-w</a></p>
<p>Indexing for full text search in PostgreSQL - Compose Articles
<a href="https://www.compose.com/articles/indexing-for-full-text-search-in-postgresql/">https://www.compose.com/articles/indexing-for-full-text-search-in-postgresql/</a></p>
<p>EikosPartners/windowmanagerjs: A framework to manage multiple dockable HTML windows.
<a href="https://github.com/EikosPartners/windowmanagerjs">https://github.com/EikosPartners/windowmanagerjs</a></p>
<p>dmvaldman/samsara: ☸️ Continuous UI
<a href="https://github.com/dmvaldman/samsara">https://github.com/dmvaldman/samsara</a></p>
<p>OrigenStudio/material-ui-layout: Declarative layout for Material UI
<a href="https://github.com/OrigenStudio/material-ui-layout">https://github.com/OrigenStudio/material-ui-layout</a></p>
<p>trstringer/electron-flexbox-ui-layout: Common UI layout for an Electron/React app using Flexbox
<a href="https://github.com/trstringer/electron-flexbox-ui-layout">https://github.com/trstringer/electron-flexbox-ui-layout</a></p>
<p>Bricks.js
<a href="http://callmecavs.com/bricks.js/">http://callmecavs.com/bricks.js/</a></p>
<p>callmecavs/bricks.js: A blazing fast masonry layout generator for fixed width elements.
<a href="https://github.com/callmecavs/bricks.js">https://github.com/callmecavs/bricks.js</a></p>
<p>desandro/masonry: Cascading grid layout plugin
<a href="https://github.com/desandro/masonry">https://github.com/desandro/masonry</a></p>
<p>jsPanel
<a href="https://jspanel.de/">https://jspanel.de/</a></p>
<p>Flyer53 (Stefan Sträßer)
<a href="https://github.com/Flyer53/">https://github.com/Flyer53/</a></p>
<p>Flyer53/jsPanel4: A JavaScript library to create highly configurable floating panels, modals, tooltips, hints/notifiers/alerts or contextmenus for use in backend solutions and other web applications.
<a href="https://github.com/Flyer53/jsPanel4">https://github.com/Flyer53/jsPanel4</a></p>
<p>Flyer53/jsPanel: A jQuery Plugin to create highly configurable floating panels, modals, tooltips and hints/notifiers for use in a backend solution and other web applications.
<a href="https://github.com/Flyer53/jsPanel">https://github.com/Flyer53/jsPanel</a></p>
<p>PhosphorJS: About
<a href="https://phosphorjs.github.io/about.html">https://phosphorjs.github.io/about.html</a></p>
<p>coderespawn/dock-spawn: Dock Spawn is a web based dock layout engine that aids in creating flexible user interfaces by enabling panels to be docked on the screen similar to Visual Studio IDE
<a href="https://github.com/coderespawn/dock-spawn">https://github.com/coderespawn/dock-spawn</a></p>
<p>millennialmedia/panels: A jQuery plugin for creating dockable panels in your web application
<a href="https://github.com/millennialmedia/panels">https://github.com/millennialmedia/panels</a></p>
<p>gridstack.js | Build interactive dashboards in minutes.
<a href="https://gridstackjs.com/">https://gridstackjs.com/</a></p>
<p>20+ Best Dashboard Frameworks » CSS Author
<a href="https://cssauthor.com/dashboard-frameworks/">https://cssauthor.com/dashboard-frameworks/</a></p>
<p>Tabbed panels using CSS
<a href="http://code.iamkate.com/html-and-css/tabbed-panels/">http://code.iamkate.com/html-and-css/tabbed-panels/</a></p>
<p>How to search hyphenated words in PostgreSQL full text search? - Database Administrators Stack Exchange
<a href="https://dba.stackexchange.com/questions/204588/how-to-search-hyphenated-words-in-postgresql-full-text-search/204601#204601">https://dba.stackexchange.com/questions/204588/how-to-search-hyphenated-words-in-postgresql-full-text-search/204601#204601</a></p>
<p>regex - Escape function for regular expression or LIKE patterns - Stack Overflow
<a href="https://stackoverflow.com/questions/5144036/escape-function-for-regular-expression-or-like-patterns/45741630#45741630">https://stackoverflow.com/questions/5144036/escape-function-for-regular-expression-or-like-patterns/45741630#45741630</a></p>
<p>PostgreSQL: Documentation: 12: 12.6. Dictionaries
<a href="https://www.postgresql.org/docs/current/textsearch-dictionaries.html">https://www.postgresql.org/docs/current/textsearch-dictionaries.html</a></p>
<p>PostgreSQL: Documentation: 12: 12.6. Dictionaries
<a href="https://www.postgresql.org/docs/current/textsearch-dictionaries.html#TEXTSEARCH-THESAURUS">https://www.postgresql.org/docs/current/textsearch-dictionaries.html#TEXTSEARCH-THESAURUS</a></p>
<p>postgresql - Match a phrase ending in a prefix with full text search - Stack Overflow
<a href="https://stackoverflow.com/questions/6155592/match-a-phrase-ending-in-a-prefix-with-full-text-search/41112803#41112803">https://stackoverflow.com/questions/6155592/match-a-phrase-ending-in-a-prefix-with-full-text-search/41112803#41112803</a></p>
<p>Tutorial | PGroonga
<a href="https://pgroonga.github.io/tutorial/">https://pgroonga.github.io/tutorial/</a></p>
<p>index - PostgreSQL FTS and Trigram-similarity Query Optimization - Database Administrators Stack Exchange
<a href="https://dba.stackexchange.com/questions/56224/postgresql-fts-and-trigram-similarity-query-optimization/56232#56232">https://dba.stackexchange.com/questions/56224/postgresql-fts-and-trigram-similarity-query-optimization/56232#56232</a></p>
<p>‘postgresql-performance’ tag wiki - Database Administrators Stack Exchange
<a href="https://dba.stackexchange.com/tags/postgresql-performance/info">https://dba.stackexchange.com/tags/postgresql-performance/info</a></p>
<p>sql - Are PostgreSQL column names case-sensitive? - Stack Overflow
<a href="https://stackoverflow.com/questions/20878932/are-postgresql-column-names-case-sensitive/20880247#20880247">https://stackoverflow.com/questions/20878932/are-postgresql-column-names-case-sensitive/20880247#20880247</a></p>
<p>PostgreSQL: Documentation: 12: 12.4. Additional Features
<a href="https://www.postgresql.org/docs/current/textsearch-features.html#TEXTSEARCH-QUERY-REWRITING">https://www.postgresql.org/docs/current/textsearch-features.html#TEXTSEARCH-QUERY-REWRITING</a></p>
<p>Postgresql full text search vs Solr – Charles Nagy
<a href="http://charlesnagy.info/it/postgresql/postgresql-full-text-search-vs-solr">http://charlesnagy.info/it/postgresql/postgresql-full-text-search-vs-solr</a></p>
<p>Postgres full-text search is Good Enough!
<a href="http://rachbelaid.com/postgres-full-text-search-is-good-enough/">http://rachbelaid.com/postgres-full-text-search-is-good-enough/</a></p>
<p>Types of Indexes in PostgreSQL - Highgo Software Inc.
<a href="https://www.highgo.ca/2020/06/22/types-of-indexes-in-postgresql/?utm_source=rss&amp;utm_medium=rss&amp;utm_campaign=types-of-indexes-in-postgresql">https://www.highgo.ca/2020/06/22/types-of-indexes-in-postgresql/?utm_source=rss&amp;utm_medium=rss&amp;utm_campaign=types-of-indexes-in-postgresql</a></p>
<p>PostgreSQL: Documentation: 12: Chapter 12. Full Text Search
<a href="https://www.postgresql.org/docs/current/textsearch.html">https://www.postgresql.org/docs/current/textsearch.html</a></p>
<p>Open Source Search: The Creators of Elasticsearch, ELK Stack &amp; Kibana | Elastic
<a href="https://www.elastic.co/">https://www.elastic.co/</a></p>
<p>[jira] [Commented] (LUCENE-2878) Allow Scorer to expose positions and payloads aka. nuke spans
<a href="https://mail-archives.apache.org/mod_mbox/lucene-dev/201207.mbox/%3C2061698841.73547.1342661195362.JavaMail.jiratomcat@issues-vm%3E">https://mail-archives.apache.org/mod_mbox/lucene-dev/201207.mbox/&lt;2061698841.73547.1342661195362.JavaMail.jiratomcat@issues-vm&gt;</a></p>
<p>How to add a collapsible section in markdown.
<a href="https://gist.github.com/pierrejoubert73/902cc94d79424356a8d20be2b382e1ab">https://gist.github.com/pierrejoubert73/902cc94d79424356a8d20be2b382e1ab</a></p>
<p>Redocly/redoc: 📘 OpenAPI/Swagger-generated API Reference Documentation
<a href="https://github.com/Redocly/redoc">https://github.com/Redocly/redoc</a></p>
<p>simonhaenisch/prettier-plugin-organize-imports: Make Prettier organize your imports using the TypeScript language service API.
<a href="https://github.com/simonhaenisch/prettier-plugin-organize-imports">https://github.com/simonhaenisch/prettier-plugin-organize-imports</a></p>
<p>shins/include.md at master · Mermade/shins
<a href="https://github.com/Mermade/shins/blob/master/docs/include.md">https://github.com/Mermade/shins/blob/master/docs/include.md</a></p>
<p>Mermade/widdershins: OpenAPI / Swagger, AsyncAPI &amp; Semoasa definitions to Slate / Shins compatible markdown
<a href="https://github.com/Mermade/widdershins/">https://github.com/Mermade/widdershins/</a></p>
<p>Apache Solr vs Elasticsearch: The Feature Smackdown
<a href="https://solr-vs-elasticsearch.com/">https://solr-vs-elasticsearch.com/</a>
⚠️ Pay attention / do read the notes in the section near the end called “Thoughts…”</p>
<p>Why the Apache Lucene and Solr “divorce” is better for developers and users
<a href="https://www.techrepublic.com/article/why-the-apache-lucene-and-solr-divorce-is-better-for-developers-and-users/">https://www.techrepublic.com/article/why-the-apache-lucene-and-solr-divorce-is-better-for-developers-and-users/</a></p>
<p>DB-Engines: System Properties Comparison Elasticsearch vs. Solr
<a href="https://db-engines.com/en/system/Elasticsearch%3BSolr">https://db-engines.com/en/system/Elasticsearch%3BSolr</a></p>
<p>Solr vs. Elasticsearch: Performance Differences &amp; More. How to Decide Which One is Best for You
<a href="https://sematext.com/blog/solr-vs-elasticsearch-differences/">https://sematext.com/blog/solr-vs-elasticsearch-differences/</a></p>
<p>Taking Solr to Production
<a href="https://lucene.apache.org/solr/guide/8_4/taking-solr-to-production.html">https://lucene.apache.org/solr/guide/8_4/taking-solr-to-production.html</a>
Note that both Solr and ElasticSearch have user management, etc. which are features we do not want/need. Solr, according to the sematext article above, is the one that’s more suitable for ‘static data &amp; full text search’: we are not interested in ‘log analysis’ or ‘aggregation’ that seems to be the primary use case of ElasticSearch. <a href="https://stackoverflow.com/questions/33283725/what-are-some-use-cases-for-using-elasticsearch-versus-standard-sql-queries">https://stackoverflow.com/questions/33283725/what-are-some-use-cases-for-using-elasticsearch-versus-standard-sql-queries</a> – that SO answer compares ES against classic RDBMS which is bloody obvious, while it doesn’t compare against Solr. <a href="https://www.nextbrick.com/blog/differences-between-apache-solr-and-apache-lucene/">https://www.nextbrick.com/blog/differences-between-apache-solr-and-apache-lucene/</a> <a href="https://www.nextbrick.com/blog/what-are-the-top-solr-metrics-to-monitor/">https://www.nextbrick.com/blog/what-are-the-top-solr-metrics-to-monitor/</a></p>
<p>Solr on Windows (and Linux)
<a href="https://lucene.apache.org/solr/guide/7_0/installing-solr.html">https://lucene.apache.org/solr/guide/7_0/installing-solr.html</a></p>
<p><a href="https://lucene.apache.org/solr/">https://lucene.apache.org/solr/</a>
Solr also seems to be more flexible when it comes to search plugins, but I don’t know if anyone will need those. Solr, however, is fully open-source while ElasticSearch is a little different: <a href="https://www.elastic.co/blog/doubling-down-on-open">https://www.elastic.co/blog/doubling-down-on-open</a> <a href="https://sematext.com/blog/open-distro-elasticsearch-review/">https://sematext.com/blog/open-distro-elasticsearch-review/</a> <a href="https://opendistro.github.io/for-elasticsearch/">https://opendistro.github.io/for-elasticsearch/</a> <a href="https://aws.amazon.com/blogs/opensource/keeping-open-source-open-open-distro-for-elasticsearch/">https://aws.amazon.com/blogs/opensource/keeping-open-source-open-open-distro-for-elasticsearch/</a>
<a href="https://opendistro.github.io/for-elasticsearch-docs/docs/install/windows/">https://opendistro.github.io/for-elasticsearch-docs/docs/install/windows/</a></p>
<p><a href="https://www.elastic.co/guide/en/elasticsearch/reference/current/windows.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/windows.html</a></p>
<p><a href="https://www.elastic.co/guide/en/elasticsearch/reference/current/filter-search-results.html#post-filter">https://www.elastic.co/guide/en/elasticsearch/reference/current/filter-search-results.html#post-filter</a></p>
<p><a href="https://sematext.com/guides/elasticsearch">https://sematext.com/guides/elasticsearch</a></p>
<p><a href="https://sematext.com/guides/solr/">https://sematext.com/guides/solr/</a></p>
<p><a href="https://trends.google.com/trends/explore?cat=31&amp;date=all&amp;q=lucene.net,elasticsearch%20.net">https://trends.google.com/trends/explore?cat=31&amp;date=all&amp;q=lucene.net,elasticsearch .net</a>
<a href="http://Lucene.NET">Lucene.NET</a> interest vs. <a href="http://ElasticSearch.NET">ElasticSearch.NET</a>, which is the client interface code for ElasticSearch written in C#. What you see is <a href="http://Lucene.NET">Lucene.NET</a> slowly fading to nil from 2006 to 2020 AD.
<img src="assets/google-trends-lucene.net.png" alt=""></p>
<p><a href="https://trends.google.com/trends/explore?cat=31&amp;date=all&amp;q=lucene.net,lucene,solr,elasticsearch">https://trends.google.com/trends/explore?cat=31&amp;date=all&amp;q=lucene.net,lucene,solr,elasticsearch</a>
<img src="assets/google-trends-lucene.net2.png" alt=""></p>
<p><a href="https://trends.google.com/trends/explore?cat=31&amp;date=2011-07-16%202020-08-16&amp;q=chromely,electron.net,cefglue,cefsharp,cef">https://trends.google.com/trends/explore?cat=31&amp;date=2011-07-16 2020-08-16&amp;q=chromely,electron.net,cefglue,cefsharp,cef</a>
<img src="assets/google-trends-cef-et-al1.png" alt="">
<img src="assets/google-trends-cef-et-al2.png" alt="">
If these trends are anything to go by, there’s not much interest in CEFGlue, which is cross platform, while there’s much more interest in CEFSharp, which is Windows-only. Also note that the C# CEF wrappers get much less attention than the straight C/C++ embedded browser component CEF, which is the core of Electron and several others. Now to put the C# components in perspective, here’s the trend graph with Electron included (and we drop CEFGlue to make room):
<img src="assets/google-trends-cef-et-al3.png" alt="">
and to show that we (or rather: Google) did not confuse that one with the physical entity called an electron, here’s that electron search filter redone so it’s very specific: note the correlation in the upswitng since 2014 for both, while this latter trend query of course delivers fewer hits over the entire period:
<img src="assets/google-trends-cef-et-al4.png" alt=""></p>
<p><a href="https://trends.google.com/trends/explore?cat=31&amp;date=2011-07-16%202020-08-16&amp;q=winforms,wpf%20.net,%2Fg%2F11bw_559wr,cefsharp,cef">https://trends.google.com/trends/explore?cat=31&amp;date=2011-07-16 2020-08-16&amp;q=winforms,wpf .net,%2Fg%2F11bw_559wr,cefsharp,cef</a>
<img src="assets/google-trends-cef-et-al5.png" alt="">
and redone to show that the google analystics warning there is irrelevant for this particular trend analysis: compare the <code>electron</code> curves above and below (<em>topic</em> and <em>search term</em>):
<img src="assets/google-trends-cef-et-al6.png" alt=""></p>
<p>Now that we’re comparing trends, just curious about programming languages used or to be used in Qiqqa:
<img src="assets/google-trends-cef-et-al10.png" alt="">
here Electron and CEF sink into the noise floor, while C# and JavaScript are about on par with one another, while NodeJS is making a wee bit of noise in the lowest percent range. Conclusion: it doesn’t matter all that much whether we code in C# or JavaScript, if we anticipate developer availability (that’s a rough estimate, but good enough for me right now). How about my old pals?
<a href="https://trends.google.com/trends/explore?cat=31&amp;date=2011-07-16%202020-08-16&amp;q=C%23,javascript,c%2B%2B,html,css"><img src="assets/google-trends-cef-et-al11.png" alt=""></a>
Hm, compare that with <a href="https://insights.stackoverflow.com/survey/2019">the latest SO languages vs pay grade / empoyment / interest poll</a>: it’s all mainstream, though <a href="https://insights.stackoverflow.com/survey/2019#technology-_-programming-scripting-and-markup-languages">JavaScript has the advantage</a>, or <a href="https://insights.stackoverflow.com/survey/2019#technology-_-other-frameworks-libraries-and-tools">does it? (Count .NET+.NETcore vs. NodeJS…)</a> See <a href="https://insights.stackoverflow.com/survey/2019#developer-profile-_-contributing-to-open-source">the link</a> though for an interesting tidbit: C# devs as a population are less inclined to contribute to open source, apparently. 😢🤔</p>
<p><a href="https://trends.google.com/trends/explore?cat=31&amp;date=all&amp;q=winforms,wpf%20.net,%2Fg%2F11bw_559wr,mfc%20windows,cef">https://trends.google.com/trends/explore?cat=31&amp;date=all&amp;q=winforms,wpf .net,%2Fg%2F11bw_559wr,mfc windows,cef</a>
<img src="assets/google-trends-cef-et-al12.png" alt="">
and then there’s the current year in
<img src="assets/google-trends-cef-et-al13.png" alt="">
which indicates to me that electron is sort of steady in mind’s eye, while WPF is still slowly declining – or is that wishful thinking?
Anyway, back in the day I used a few frameworks, before having to land with MFC, which I kinda liked (thanks to an MSJ article by Paul diLascia which enabled me to hack the bugger to bits) and after that it’s been a lot of <em>meh</em> (old wine, new bags) outside the HTML+CSS realm. Looks like we’re indeed heading there…</p>


    <footer>
      © 2020 Qiqqa Contributors ::
      <a href="https://github.com/GerHobbelt/qiqqa-open-source/blob/docs-src/Progress in Development/Considering the Way Forward/Full-Text Search Engines.md">Edit this page on GitHub</a>
    </footer>
  </body>
</html>