<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    
    <h1>Nasty URLs for PDFs</h1>
<ul>
<li>
<p><a href="http://dspace.bracu.ac.bd/xmlui/bitstream/handle/10361/7620/12201001%20&amp;%2013101230_CSE.pdf?sequence=1">http://dspace.bracu.ac.bd/xmlui/bitstream/handle/10361/7620/12201001 &amp; 13101230_CSE.pdf?sequence=1</a></p>
<p>This link downloads/views a PDF fine in MS Edge / Chrome, but produces a HTML/404 crash page when using <code>curl</code> as in <code>curl -v -L http://dspace.bracu.ac.bd/xmlui/bitstream/handle/10361/7620/12201001%20&amp;%2013101230_CSE.pdf?sequence=1 -o test.pdf</code></p>
</li>
<li>
<p><a href="https://www.aaai.org/Papers/Workshops/2006/WS-06-06/WS06-06-006.pdf">https://www.aaai.org/Papers/Workshops/2006/WS-06-06/WS06-06-006.pdf</a></p>
<p>Downloads OK in the browser, but <code>curl -v -L</code> outputs this:</p>
<pre><code>&lt; HTTP/1.1 406 Not Acceptable
&lt; Date: Thu, 01 Oct 2020 21:00:39 GMT
&lt; Server: Apache
&lt; Content-Length: 373
&lt; Content-Type: text/html; charset=iso-8859-1
</code></pre>
<ul>
<li>and another one: <a href="https://www.aaai.org/Papers/Workshops/2006/WS-06-06/WS06-06-003.pdf">https://www.aaai.org/Papers/Workshops/2006/WS-06-06/WS06-06-003.pdf</a></li>
<li><a href="https://www.aaai.org/Papers/Workshops/2006/WS-06-09/WS06-09-006.pdf">https://www.aaai.org/Papers/Workshops/2006/WS-06-09/WS06-09-006.pdf</a></li>
</ul>
</li>
<li>
<p><a href="https://aaaipress.org/Papers/Workshops/1998/WS-98-07/WS98-07-015.pdf">https://aaaipress.org/Papers/Workshops/1998/WS-98-07/WS98-07-015.pdf</a></p>
<p>Conneection Not Secure (not tested with <code>curl</code> though; this is a browser report)</p>
</li>
<li>
<p><a href="http://en.saif.sjtu.edu.cn/junpan/Peso_RFS.pdf">http://en.saif.sjtu.edu.cn/junpan/Peso_RFS.pdf</a></p>
<p>Weird DNS shit happening. Bing and Google know this one, browser cannot reach.</p>
</li>
</ul>

  </head>
  <body>

    <h1>Nasty URLs for PDFs</h1>
<ul>
<li>
<p><a href="http://dspace.bracu.ac.bd/xmlui/bitstream/handle/10361/7620/12201001%20&amp;%2013101230_CSE.pdf?sequence=1">http://dspace.bracu.ac.bd/xmlui/bitstream/handle/10361/7620/12201001 &amp; 13101230_CSE.pdf?sequence=1</a></p>
<p>This link downloads/views a PDF fine in MS Edge / Chrome, but produces a HTML/404 crash page when using <code>curl</code> as in <code>curl -v -L http://dspace.bracu.ac.bd/xmlui/bitstream/handle/10361/7620/12201001%20&amp;%2013101230_CSE.pdf?sequence=1 -o test.pdf</code></p>
</li>
<li>
<p><a href="https://www.aaai.org/Papers/Workshops/2006/WS-06-06/WS06-06-006.pdf">https://www.aaai.org/Papers/Workshops/2006/WS-06-06/WS06-06-006.pdf</a></p>
<p>Downloads OK in the browser, but <code>curl -v -L</code> outputs this:</p>
<pre><code>&lt; HTTP/1.1 406 Not Acceptable
&lt; Date: Thu, 01 Oct 2020 21:00:39 GMT
&lt; Server: Apache
&lt; Content-Length: 373
&lt; Content-Type: text/html; charset=iso-8859-1
</code></pre>
<ul>
<li>and another one: <a href="https://www.aaai.org/Papers/Workshops/2006/WS-06-06/WS06-06-003.pdf">https://www.aaai.org/Papers/Workshops/2006/WS-06-06/WS06-06-003.pdf</a></li>
<li><a href="https://www.aaai.org/Papers/Workshops/2006/WS-06-09/WS06-09-006.pdf">https://www.aaai.org/Papers/Workshops/2006/WS-06-09/WS06-09-006.pdf</a></li>
</ul>
</li>
<li>
<p><a href="https://aaaipress.org/Papers/Workshops/1998/WS-98-07/WS98-07-015.pdf">https://aaaipress.org/Papers/Workshops/1998/WS-98-07/WS98-07-015.pdf</a></p>
<p>Conneection Not Secure (not tested with <code>curl</code> though; this is a browser report)</p>
</li>
<li>
<p><a href="http://en.saif.sjtu.edu.cn/junpan/Peso_RFS.pdf">http://en.saif.sjtu.edu.cn/junpan/Peso_RFS.pdf</a></p>
<p>Weird DNS shit happening. Bing and Google know this one, browser cannot reach.</p>
</li>
</ul>


    <footer>
      © 2020 Qiqqa Contributors ::
      <a href="https://github.com/GerHobbelt/qiqqa-open-source/blob/docs-src/Technology/Odds 'n' Ends/PDFs in the Wild/Testing - Nasty URLs for PDFs.md">Edit this page on GitHub</a>
    </footer>
  </body>
</html>