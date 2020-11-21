from selenium.webdriver.chrome.options import Options
from selenium import webdriver
import webbrowser
import re
import os

chrome_options = Options()
chrome_options.add_argument("--headless")
driver = webdriver.Chrome('C:\\MotherHappy\\chromedriver.exe',chrome_options = chrome_options)
with open("c:\\MotherHappy\\Link.txt",'r') as f:
    x = f.read()
#try:
    
driver.get(x)

driver.switch_to.frame(driver.find_element_by_xpath("//iframe[2]"))
driver.switch_to.frame(driver.find_element_by_xpath("/html/body/iframe"))

page = driver.page_source
pattern = re.compile(r"xfplay://dna=.*")
print(page)
result = "\""+re.search(pattern,page).group()
end =result.split("\"")
print(end[1])
webbrowser.open(end[1])

print('可關閉此程式')
driver.quit()

#except:
 #   pass