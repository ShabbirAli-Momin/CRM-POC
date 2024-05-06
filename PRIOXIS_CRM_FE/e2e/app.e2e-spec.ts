import { PRIOXIS_CRM_POC_TemplatePage } from './app.po';

describe('PRIOXIS_CRM_POC_ App', function() {
  let page: PRIOXIS_CRM_POC_TemplatePage;

  beforeEach(() => {
    page = new PRIOXIS_CRM_POC_TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
