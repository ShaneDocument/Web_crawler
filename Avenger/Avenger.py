import time
import calendar
from bs4 import BeautifulSoup
from urllib.request import urlopen
import requests
import webbrowser
def date():
    #print(time.strftime("%m//%d %H:%M:%S",time.localtime()))
    year = int(time.strftime("%Y",time.localtime()))
    month = int(time.strftime("%m",time.localtime()))
    day = int(time.strftime("%d",time.localtime()))
    book_day = day+6
    if month == 1 or month==3 or month==5 or month== 7 or month== 8 or month==10 or month==12:
        if book_day>31:
            book_day = book_day-31
            if month !=12:
                month = month+1
            else:
                month = 1
    if month == 4 or month== 6 or month== 9 or month==11:
        if book_day>30:
            book_day = book_day-30
            if month !=12:
                month =month+1
            else:
                month = 1
    if month == 2:
        if book_day > calendar.mdays[2]:
            book_day = book_day-calendar.mdays[2]
            month= month+1
    if month<10:
        month = '0'+str(month)
    if book_day<10:
        book_day = '0'+str(book_day)
    date = str(year)+'-'+str(month)+'-'+str(book_day)
    #print(date)
    return date


triger_time1 = "12:00:00"
triger_time2 = "00:00:00"
get_some_ticket1="11:59:00"
get_some_ticket2 = "23:59:00"


AvengerRequest = requests.session()

ID='D122785346'
pw='Eric_87123'
branch_no = 'TD'

bookurl = 'https://bookseat.tkblearning.com.tw/book-seat/student/bookSeat/index'

data_notoken = {
'st_id': ID,
'st_pw': pw}
print('Avenger已啟動.')

while True:
    time.sleep(0.3)
    get_ticket = False
    while time.strftime("%H:%M:%S",time.localtime()) == get_some_ticket1 or time.strftime("%H:%M:%S",time.localtime())== get_some_ticket2:
        if get_ticket == False:
            book = AvengerRequest.get(bookurl)
            cookies = book.cookies.get_dict()['JSESSIONID']
            print('已取得cookie.')
            headers = {
            'Connection': 'keep-alive',
            'cookie' :  'JSESSIONID='+cookies,#+'; _ga=GA1.3.426656697.1563035552; _fbp=fb.2.1563035555527.1246056051; _gid=GA1.3.1622054807.1563122088; _gat_UA-56215453-1=1',
            'Host': 'bookseat.tkblearning.com.tw',
            'Referer': 'https://bookseat.tkblearning.com.tw/book-seat/student/bookSeat/index',
            'User-Agent': 'Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.100 Safari/537.36'
            }
            post_headers = {
            'Connection': 'keep-alive',
            'cookie' :  'JSESSIONID='+cookies,#+'; _ga=GA1.3.426656697.1563035552; _fbp=fb.2.1563035555527.1246056051; _gid=GA1.3.1622054807.1563122088; _gat_UA-56215453-1=1',
            'Host': 'bookseat.tkblearning.com.tw',
            'Origin': 'https://bookseat.tkblearning.com.tw',
            'Referer': 'https://bookseat.tkblearning.com.tw/book-seat/student/bookSeat/index',
            'User-Agent': 'Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.100 Safari/537.36'
            }

            soup = BeautifulSoup(book.text,features = 'lxml')
            token = soup.find_all('input')
            value = token[0]['value']
            print('已取得token.')
            data_token = {'access_token': value,
            'toURL': '/student/bookSeat/index',
            'id': ID,
            'pwd': pw}


            logincheck = AvengerRequest.post('https://bookseat.tkblearning.com.tw/book-seat/student/sLoginLog/logCheck',data = data_notoken,headers = post_headers)
            login = AvengerRequest.post('https://bookseat.tkblearning.com.tw/book-seat/student/login/login',data = data_token,headers = post_headers)
            loginrecord = AvengerRequest.get('https://bookseat.tkblearning.com.tw/book-seat/student/login/loginRecord',headers=headers)
            book = AvengerRequest.get('https://bookseat.tkblearning.com.tw/book-seat/student/bookSeat/index',headers = headers)
            gettoken = AvengerRequest.get(bookurl)
            soup = BeautifulSoup(gettoken.text,features = 'lxml')
            token = soup.find_all('input')
            value = token[1]['value']
            print('已取得token.')
            option = soup.find_all('option')
            class_data = option[1]['value']
            print('已取得課程資訊')
            book_url = 'https://bookseat.tkblearning.com.tw/book-seat/student/bookSeat/book'
        
            get_ticket = True
        else:
            break

    do_it = True
    
    #print("im in",k)
    time.sleep(0.2)
    while time.strftime("%H:%M:%S",time.localtime()) == triger_time1 or time.strftime("%H:%M:%S",time.localtime())== triger_time2:

        date1 = date()
     
        book_data1 = {
        'class_data': class_data, 
        'date': date1,
        'branch_no': branch_no,
        'session_time[]': [2,3],
        'access_token': value}
        if do_it==True:
            print('開始預約')
            book_seat = AvengerRequest.post(book_url,data = book_data1,headers = post_headers)
        if str(book_seat)=='<Response [200]>' and do_it==True:
            print(date1)
            do_it = False
            #print(book_seat.text)
            print('預約成功，請上網查看.')