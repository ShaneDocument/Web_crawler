import requests
from bs4 import BeautifulSoup
import urllib.request
import re
import os
import time





def mkp(path):
    if not os.path.exists(path):
        os.makedirs(path)
    else:
        print('The path was already made.')

with open('C:\\MotherHappy\\temp.txt','r',encoding = 'utf-8') as f:
    x = f.read()

path = 'C:\\MotherHappy\\series\\'+x
mkp(path)
data = {'s':'home-vod-innersearch-q-'+x}
url = 'http://www.58b.tv/index.php?'
headers = {'User-Agent': 'Mozilla/5.0 (Macintosh; Intel Mac OS X 10_13_4) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36'}

tstart = time.time()
r = requests.get(url,params = data)
html=urllib.request.Request(r.url,headers = headers)
req = urllib.request.urlopen(html).read().decode('utf-8')
soup = BeautifulSoup(req,features = 'lxml')



link = soup.find_all('a',{'href':re.compile('/vod-read-id.*')})
imgs = soup.find_all('img',{'src':re.compile('http://img.58b.tv/.*')})
intros = soup.find_all('span',{'class':'st'})
i=1
x=0

for l in link:
    
    if i%2==0:
        
        print('http://www.58b.tv'+l['href']+l.get_text()+'\n')
        url = 'http://www.58b.tv'+l['href']
        
        
        html = urllib.request.Request(url,headers = headers)
        req = urllib.request.urlopen(html).read().decode('utf-8')
        
        soup = BeautifulSoup(req,features = 'lxml')
        series = soup.find_all('div','vpl')
        '''
        series = soup.find('div',{'id':re.compile('0_FLV.*')})
        if series!=None:            
            FLVs = series.find_all('a',{'href':re.compile('.*')})
            for flv in FLVs:
                print(flv['href'])
                '''
        
        for k in range(10):
            try:
                
                xfplay = series[k].find_all('a',{'href':re.compile('/vod-play-id-(\d+)-sid-.*')})
            except:
                pass
            if len(xfplay)!=0:
                break
                
            
        for series in xfplay:
            print(series['href']+series.get_text())
        name = re.sub('[\\\/\:\*\?\"\<\>\|]',' ',l.get_text())
        
        f=open(path+'\\'+name+'.txt','w',encoding='utf-8')
        for s in xfplay:
            f.write('http://www.58b.tv'+s['href']+'\n'+s.get_text()+'\n')
        f.close()
        
        with open(path+'\\'+name+'img.Data','w',encoding = 'utf-8') as f:
            f.write(imgs[x]['src'])
        
        with open(path+'\\'+name+'intro.Data','w',encoding = 'utf-8') as f:
            f.write(intros[x].get_text())
        x=x+1
        
    i=i+1
print('%f'%(time.time()-tstart))
    
    
    
