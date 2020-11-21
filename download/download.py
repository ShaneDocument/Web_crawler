from bs4 import BeautifulSoup
import requests
from urllib.request import urlopen,urlretrieve

import urllib.request
import ssl
import re
import os
ssl._create_default_https_context = ssl._create_unverified_context
subject = ['資料結構與演算法','作業系統與計算機組織','離散數學與線性代數','線性代數','計算機組織','計算機概論','系統程式','離散數學']
url ='https://rapid.lib.ncu.edu.tw/cexamn/EC02.html'
headers = {'User-Agent': 'Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_4) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36'}
r = urllib.request.Request(url,headers = headers)
html = urlopen(url).read().decode('utf-8',errors='ignore')
print(html)

soup = BeautifulSoup(html, features ='lxml')
tr = soup.find_all('tr')
k=0
for classes in tr:
    
    link = classes.find_all('a',{'href':re.compile('.*\.pdf')})
    if not os.path.isdir(subject[k]):
        os.mkdir(subject[k])
    print('下載 '+subject[k]+' 中....\n')
    for test in link:
        pdf = 'https://rapid.lib.ncu.edu.tw/cexamn/'+test['href']
        urlretrieve(pdf,"./"+subject[k]+'/'+test['href'].lstrip('exam\/'))
        print(test['href'].lstrip('exam\/')+' 下載完成\n')
    print(subject[k]+'下載完成\n')
    k=k+1
print('全部下載完成.\n')
