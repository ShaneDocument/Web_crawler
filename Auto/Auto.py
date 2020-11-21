from selenium.webdriver.chrome.options import Options
from selenium import webdriver
import os
import shutil
def mak(path):    
    if not os.path.exists(path):
        os.makedirs(path)

#chrome_options = Options()
#chrome_options.add_argument('--headless')
#driver = webdriver.Chrome('/Users/eric/Downloads/chromedriver',chrome_options=chrome_options)

path = 'C:\Auto'
mak(path)
if os.path.isfile(path+'\chromedriver.exe'):
    print('ChromeDriver is exist.')
else:
    try:
        shutil.copy('chromedriver.exe',path)
    except shutil.SameFileError:
        pass

username = input("學號:")
password = input("密碼:")
number = input("這學期修的堂數:")
driver = webdriver.Chrome('.\chromedriver.exe')
url = 'https://ohs01.ntpu.edu.tw/student_new.htm'


driver.get(url)
i=int(number)+1

driver.find_element_by_name("stud_num").clear()
driver.find_element_by_name("stud_num").send_keys(username)
driver.find_element_by_name("passwd").clear()
driver.find_element_by_name("passwd").send_keys(password)
driver.find_element_by_id("loginBtn1").click()
try:
    
    driver.switch_to.frame("leftFrame")
except:
    print('There is a wrong with studentID or password.')
    os.system("pause")
driver.find_element_by_link_text(u"107學年成績").click()

for a in range(2,i+1):   
    driver.switch_to.parent_frame()
    driver.switch_to.frame("mainFrame")
    b = str(a)
    
    try:
        
        driver.find_element_by_xpath("//tr["+b+"]/td[3]/a[contains(@href,'g0002')]").click()
        driver.find_element_by_name("q03").click()
        driver.find_element_by_name("q1").click()
        driver.find_element_by_name("q2").click()
        driver.find_element_by_name("q3").click()
        driver.find_element_by_name("q4").click()
        driver.find_element_by_name("q5").click()
        driver.find_element_by_name("q6").click()
        driver.find_element_by_name("q7").click()
        driver.find_element_by_name("q8").click()
        driver.find_element_by_name("q9").click()
        driver.find_element_by_name("q10").click()
        driver.find_element_by_name("q11").click()
        driver.find_element_by_name("q12").click()
        driver.find_element_by_name("q13").click()
        driver.find_element_by_name("q14").click()
        driver.find_element_by_name("q19").click()
        driver.find_element_by_name("q20").click()
        driver.find_element_by_name("q21").click()
        driver.find_element_by_name("q23").click()
        driver.find_element_by_name("q24").click()
        driver.find_element_by_name("qc47").click()
        driver.find_element_by_name("qc48").click()
        driver.find_element_by_name("qc49").click()
        driver.find_element_by_xpath(u"(.//*[normalize-space(text()) and normalize-space(.)='四、 學生自評'])[1]/following::input[30]").click()
        driver.find_element_by_xpath(u"//input[@value='確定送出']").click()
        driver.switch_to.alert.accept()
    except:
        continue
        
print("OK!!")
        
 