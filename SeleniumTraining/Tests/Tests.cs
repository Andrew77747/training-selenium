using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace Tests
{
    public class Tests
    {
        // Эту переменную драйвера надо инициализировать в тесте
        private IWebDriver driver;

        //эти локаторы осталяю, чтобы их использовать в тесте. Они рабочие
        private WebDriverWait wait;
        private readonly By _inputYouTube = By.XPath("//input[@id='search']");
        private readonly By _searchButton = By.XPath("//button[@id='search-icon-legacy']");
        private readonly By _video = By.XPath("//a[@id='video-title']");

        // Пока все сделаем в одном тесте, далее будем разбивать
        // На месте одного коммента надо написать соответствующую строчку кода
        [Test]
        public void CheckYouTubePage()
        {
            // Инициализируем драйвер
            // Задаем неявное ожидание

            // Переходим на главную страницу ютуб
            // Разворачиваем окно браузера на полный экран
            // Вбиваем в строке пооиска "Валера, настало твое время"
            // Кликаем по кнопке поиска
            // Кликаем по первому найденному видео, чтобы запустить его
            // Останавливаем поток - пока сделаем это неправильно, но эффективно с помощью тредслипа на 5 секунд

            // Закрываем браузер
            //Глушим драйвер
        }

    }
}
