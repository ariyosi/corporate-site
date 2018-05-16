html {
  font-size: 62.5%; }

p {
  font-size: 16px;
  font-size: 1.6rem; }

header {
  background: #eaf2f4; }
  header #header_in {
    padding-top: 10px;
    padding-bottom: 4px; }
  @media (max-width: 550px) {
    header .logo {
      width: 190px; }
    header .navi {
      width: 40px;
      float: right; } }
  header .sp_navi_li {
    width: 180px;
    position: absolute;
    top: 50px;
    right: 2%;
    border: 1px solid #eee;
    background: white;
    margin: 0;
    padding: 0;
    display: none;
    z-index: 100; }
    header .sp_navi_li li {
      list-style: none;
      margin: 0;
      padding: 0; }
      header .sp_navi_li li a {
        display: block;
        padding: 10px 8px;
        border-bottom: 1px solid #eee;
        font-size: 14px;
        text-decoration: none; }

@media (max-width: 550px) {
  .pc_navi {
    display: none; }

  .sp_navi_li {
    width: 180px;
    position: absolute;
    top: 50px;
    right: 2%;
    border: 1px solid #eee;
    background: white;
    margin: 0;
    padding: 0; }

  li {
    list-style: none;
    margin: 0;
    padding: 0; }
    li a {
      display: block;
      padding: 10px 8px;
      border-bottom: 1px solid #eee;
      font-size: 14px;
      text-decoration: none; }

  .logo {
    width: 190px; }

  .navi {
    width: 40px;
    float: right; } }
@media (min-width: 551px) {
  .sp_navi {
    display: none; }

  #header_in {
    padding: 15px 0 10px 0; }

  .pc_navi_li {
    margin: 0;
    padding: 0; }
    .pc_navi_li li {
      list-style: none;
      margin: 5px 0 0 0;
      padding: 0; }
      .pc_navi_li li a {
        color: #626262;
        text-decoration: none;
        font-weight: bold;
        font-size: 14px;
        font-size: 1.4rem;
        float: left;
        padding-right: 10px; }
      .pc_navi_li li a:hover {
        color: #42b9d0; }
    .pc_navi_li li.navi_toppage a {
      background-repeat: no-repeat;
      display: inline-block;
      line-height: 40px;
      padding-left: 50px;
      background-image: url("../images/top/navi_top.png");
      background-size: 40px 40px; } }
    @media screen and (min-width: 551px) and (-webkit-min-device-pixel-ratio: 2), (min-width: 551px) and (min-resolution: 2dppx) {
      .pc_navi_li li.navi_toppage a {
        background-image: url("../images/top/navi_top@2x.png"); } }
@media (min-width: 551px) {
    .pc_navi_li li.navi_news a {
      background-repeat: no-repeat;
      display: inline-block;
      line-height: 40px;
      padding-left: 50px;
      background-image: url("../images/top/navi_news.png");
      background-size: 40px 40px; } }
    @media screen and (min-width: 551px) and (-webkit-min-device-pixel-ratio: 2), (min-width: 551px) and (min-resolution: 2dppx) {
      .pc_navi_li li.navi_news a {
        background-image: url("../images/top/navi_news@2x.png"); } }
@media (min-width: 551px) {
    .pc_navi_li li.navi_company a {
      background-repeat: no-repeat;
      display: inline-block;
      line-height: 40px;
      padding-left: 50px;
      background-image: url("../images/top/navi_company.png");
      background-size: 40px 40px; } }
    @media screen and (min-width: 551px) and (-webkit-min-device-pixel-ratio: 2), (min-width: 551px) and (min-resolution: 2dppx) {
      .pc_navi_li li.navi_company a {
        background-image: url("../images/top/navi_company@2x.png"); } }

#cover_area {
  text-align: center;
  padding: 80px 0;
  background-image: url("../images/top/cover.jpg");
  background-size: cover; }
  @media screen and (-webkit-min-device-pixel-ratio: 2), (min-resolution: 2dppx) {
    #cover_area {
      background-image: url("../images/top/cover@2x.jpg"); } }
  @media (min-width: 551px) {
    #cover_area {
      text-align: left;
      height: 420px;
      padding: 0; }
      #cover_area img {
        margin-top: 180px;
        margin-left: 70px; } }

#service_area {
  padding-top: 20px; }
  @media (min-width: 551px) {
    #service_area {
      padding-top: 30px; } }
  #service_area .columns {
    color: #626262; }
    #service_area .columns .service_title {
      font-size: 18px;
      font-size: 1.8rem;
      font-weight: bold;
      margin-top: 8px; }
    #service_area .columns p {
      font-size: 15px;
      font-size: 1.5rem;
      margin-top: 10px; }
    @media (min-width: 551px) {
      #service_area .columns .service_title {
        font-size: 16px;
        font-size: 1.6rem; }
      #service_area .columns p {
        font-size: 13px;
        font-size: 1.3rem; } }

#news_area {
  background-color: #eaf2f4; }
  @media (min-width: 551px) {
    #news_area .container {
      padding: 0px 10% 50px 10%; } }
  #news_area .news_title {
    text-align: center;
    font-size: 26px;
    font-size: 2.6rem;
    color: #42b9d0;
    padding: 15px 0 10px 0;
    font-weight: bold;
    letter-spacing: 0.2rem; }
  #news_area .news_lists li {
    list-style: none;
    font-size: 15px;
    font-size: 1.5rem; }
    #news_area .news_lists li span {
      color: #42b9d0;
      font-weight: bold;
      display: block;
      margin-bottom: 3px; }
  @media (min-width: 551px) {
    #news_area .news_title {
      font-size: 22px;
      font-size: 2.2rem;
      padding: 50px 0 41px 0; }
    #news_area .news_lists li {
      font-size: 14px;
      font-size: 1.4rem;
      margin-bottom: 20px; }
      #news_area .news_lists li span {
        display: inline;
        margin-bottom: 0px; } }

footer {
  background-color: #42b9d0;
  color: #fff;
  padding-top: 20px; }
  @media (max-width: 550px) {
    footer .container {
      margin: 0;
      padding: 0; }
    footer .sp {
      padding: 0 6%;
      margin: 0 auto; }
    footer .foot_navi {
      margin-top: 20px; }
      footer .foot_navi li {
        list-style: none;
        margin-bottom: 1px; }
        footer .foot_navi li a {
          color: #42b9d0;
          background-color: #eaf2f4;
          display: block;
          text-align: center;
          font-weight: bold;
          text-decoration: none;
          font-size: 16px;
          font-size: 1.6rem;
          padding: 16px 0; } }
  footer .foot_address {
    font-size: 16px;
    font-size: 1.6rem;
    padding-top: 10px; }
  footer .copy {
    text-align: center;
    font-size: 11px;
    font-size: 1.1rem;
    color: #b2e1ea; }
  @media (min-width: 551px) {
    footer {
      padding-top: 30px; }
      footer .foot_address {
        padding: 0px;
        font-size: 12px;
        font-size: 1.2rem; }
      footer .foot_navi {
        float: right; }
        footer .foot_navi li {
          list-style: none;
          background-repeat: no-repeat;
          background-position: left center;
          display: inline-block;
          float: left;
          margin-right: 10px;
          font-size: 11px;
          font-size: 1.1rem;
          background-image: url("../images/top/foot_arroehead.png");
          background-size: 4px 6px; } }
      @media screen and (min-width: 551px) and (-webkit-min-device-pixel-ratio: 2), (min-width: 551px) and (min-resolution: 2dppx) {
        footer .foot_navi li {
          background-image: url("../images/top/foot_arroehead@2x.png"); } }
  @media (min-width: 551px) {
        footer .foot_navi a {
          color: white;
          padding-left: 10px;
          text-decoration: none; }
        footer .foot_navi a:hover {
          color: #eaf2f4; }
      footer .copy {
        margin-top: 30px; } }

h1 {
  margin: 0;
  padding: 0; }

#sub_cover {
  text-align: center;
  font-size: 16px;
  font-weight: bold;
  color: white;
  padding-top: 40px;
  padding-right: 0px;
  padding-bottom: 40px;
  padding-left: 0px;
  margin: 0;
  letter-spacing: 0.2rem;
  background-image: url(../images/news/sub_cover.jpg);
  background-size: cover; }
  @media (min-width: 550px) {
    #sub_cover {
      padding: 80px 0;
      font-size: 32px;
      font-size: 3.2rem; } }

@media (max-width: 551px) {
  #contents {
    padding-top: 20px;
    padding-bottom: 20px; } }
@media (min-width: 550px) {
  #contents {
    padding-top: 35px;
    padding-bottom: 70px; } }

#main h2 {
  color: #42b9d0;
  border-bottom: 3px solid #42b9d0;
  font-size: 1.5rem;
  font-weight: bold;
  padding-bottom: 15px;
  line-height: 1.25;
  letter-spacing: -.1rem;
  margin-top: 0;
  margin-bottom: 2rem;
  display: block;
  font-weight: bold; }
  @media (min-width: 550px) {
    #main h2 {
      font-size: 2.0rem; } }
#main .news_li {
  font-size: 1.5rem;
  display: block;
  padding-bottom: 5px; }
  #main .news_li li {
    list-style: none;
    margin: 0;
    padding-bottom: 5px; }
    #main .news_li li span {
      color: #42b9d0;
      font-weight: bold;
      display: block;
      margin-bottom: 3px;
      padding-right: 10px; }
    @media (min-width: 550px) {
      #main .news_li li {
        padding-right: 10px; }
        #main .news_li li span {
          display: inline; } }
#main .company_title {
  margin-bottom: 0px; }
#main table {
  border-collapse: collapse;
  border-spacing: 0;
  display: table;
  border-collapse: separate;
  border-spacing: 2px;
  border-color: grey; }
#main td {
  padding: 20px 0;
  color: #626262;
  font-size: 14px;
  font-size: 1.4rem;
  text-align: left;
  border-bottom: 1px solid #E1E1E1; }
#main th {
  padding: 20px 20px 20px 0;
  color: #626262;
  font-size: 14px;
  font-size: 1.4rem;
  text-align: left;
  border-bottom: 1px solid #E1E1E1; }

@media (min-width: 550px) {
  #sidebar h3 {
    color: #42b9d0;
    font-size: 1.4rem;
    letter-spacing: 0.2rem;
    font-weight: bold;
    background-color: #f3f9fb;
    padding: 15px;
    margin-bottom: 0px; } }
@media (max-width: 551px) {
  #sidebar .pc_sidemenu {
    display: none; } }
@media (min-width: 550px) {
  #sidebar .pc_sidemenu li {
    list-style: none;
    display: block;
    border-bottom: 1px solid #e5e5e5;
    background-repeat: no-repeat;
    background-position: 8px center;
    margin-bottom: 0px;
    padding: 10px 10px 10px 20px;
    background-image: url(../images/news/side_arrow.png);
    background-size: 4px 8px; }
  #sidebar .pc_sidemenu a {
    text-decoration: none; } }

/*# sourceMappingURL=sample.cs.map */
