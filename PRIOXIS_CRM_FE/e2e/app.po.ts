import { browser, element, by } from 'protractor';

export class PRIOXIS_CRM_POC_TemplatePage {
  navigateTo() {
    return browser.get('/');
  }

  getParagraphText() {
    return element(by.css('app-root h1')).getText();
  }
}
