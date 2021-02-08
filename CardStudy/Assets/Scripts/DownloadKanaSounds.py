import os
import re
import requests
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys 
from selenium.webdriver.chrome.options import Options
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC



options = Options()
options.add_argument('--headless')
options.add_argument('--disable-gpu')
options.add_experimental_option("prefs", {
  "download.default_directory": r"/Users/frederick/Downloads",
  "download.prompt_for_download": False,
  "download.directory_upgrade": True,
  "safebrowsing.enabled": True
})

driver = webdriver.Chrome(executable_path='/Users/frederick/Documents/REPOS/WaniKani_Card_Generator/WaniKani_CardSet_Creator/chromedriver', chrome_options=options) 
print('--- driver open ---')
driver.get("http://www.dartmouth.edu/~introjpn/text/hiragana.html")

wait = WebDriverWait(driver, 10)
wait.until(EC.element_to_be_clickable((By.CSS_SELECTOR, 'a[href]')))

driver.find_element_by_css_selector('a[href]').send_keys(Keys.SPACE)


kana_sounds = driver.find_elements_by_css_selector("a[href*='.mp3']")
kana_names = driver.find_elements_by_css_selector("img[src*='hiragana/hiragana_files/']")


for i in range(len(kana_sounds)) :

  filename = re.search(r"\d+\_(\w+?)\.jpg", kana_names[i].get_attribute('src')).group(1)
  print(filename)

  r = requests.get(kana_sounds[i].get_attribute('href'),  allow_redirects=True)
  open(f'/Users/frederick/Downloads/{filename}.mp3', 'wb').write(r.content)

    



driver.close()
print('--- driver closed ---')