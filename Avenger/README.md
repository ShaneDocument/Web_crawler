# Avenger

- 程式的date() method單純在計算月份，因為post到後端的資料需要用到日期，所以需要去計算日期。比較困難的是跨月份以及大小月、閏年的部分。
- 比較需要注意的是，cookies這個變數。因為使用session，所以會自動記錄cookies的部分，
而cookies在第65行的時候去抓取名為"JSESSIONID"的資料，
這個是大碩網站防止爬蟲的值，每一次刷新頁面都會改這個值，所以爬蟲每一次都要去抓取。抓取本身不難，但發現這個機制是需要去看post出去的header的。
- 大部分的程式碼都在抓取post需要的資料。

> 開發的時間已經是好久以前了，有些程式碼"為什麼這樣寫"已經忘記了，不過基本的知識倒是帶著走的。
