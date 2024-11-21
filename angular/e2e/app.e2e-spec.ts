import { MyAbpProjectTemplatePage } from './app.po';

describe('MyAbpProject App', function() {
  let page: MyAbpProjectTemplatePage;

  beforeEach(() => {
    page = new MyAbpProjectTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
