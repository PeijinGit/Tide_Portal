<template>
      
  <div class="about">
    <!-- <div
      class="top-banner"
      style="height: 370px; background: url('/imgs/banner/关于我们.jpg')"
    ></div> -->
    <topBanner imgUrl="/imgs/banner/关于我们.jpg"/>
    <div class="about-us">
      <padTitle mTitle="公司介绍" sTitle="互联网+时代" />
      <div class="about-inner">
        <inner>
          <img src="/imgs/others/aboutTextImage.jpg" alt="" />
          <div class="about-detail-content">
            <p>
              <b
                >朝夕教育科技有限公司成立于2019年。总部位于武汉市洪山区书城路46号金地格林商业一单元。</b
              >
              <br />朝夕教育，专注于IT在线教育，注重服务与口碑，解决升职与加薪的难题。当下专注于.Net领域在线教育，开设有.Net架构班、.Net高级进阶班、.Net全栈实战班、Sql+Winform零基础快速就业班，C#+AutoCAD高薪就业班，致力于打造高品质在线教育，赋能IT人，赋能企业！升职加薪，只争朝夕！
            </p>
            <ul>
              <li>
                <span>名师授课</span>
                <p>
                  朝夕教育首创.NET架构师课程系统深入讲解原理与设计,实时在线解决学员问题
                </p>
              </li>
              <li>
                <span>名师授课</span>
                <p>
                  朝夕教育首创.NET架构师课程系统深入讲解原理与设计,实时在线解决学员问题
                </p>
              </li>
              <li>
                <span>名师授课</span>
                <p>
                  朝夕教育首创.NET架构师课程系统深入讲解原理与设计,实时在线解决学员问题
                </p>
              </li>
              <li>
                <span>名师授课</span>
                <p>
                  朝夕教育首创.NET架构师课程系统深入讲解原理与设计,实时在线解决学员问题
                </p>
              </li>
              <li>
                <span>名师授课</span>
                <p>
                  朝夕教育首创.NET架构师课程系统深入讲解原理与设计,实时在线解决学员问题
                </p>
              </li>
              <li>
                <span>名师授课</span>
                <p>
                  朝夕教育首创.NET架构师课程系统深入讲解原理与设计,实时在线解决学员问题
                </p>
              </li>
            </ul>
          </div>
        </inner>
      </div>
      <div class="about-contact">
        <inner width="880px">
          <padTitle mTitle="联系我们" />
          <img src="/imgs/icons/contact.jpg" alt="" />
          <div class="contact-detail">
            <p>企业 QQ：8888888</p>
            <p>企业微信：Apple-zhaoxijiaoyu</p>
            <p>电　　话：13163257325</p>
            <p>地　　址：江苏镇江润州区</p>
            <p>公司邮箱：xxx@zhaoxi.com</p>
            <p></p>
          </div>
        </inner>
      </div>
    </div>
    <!-- </topBanner> -->
  </div>
</template>

<script>
export default {};
</script>

<style lang="scss" scoped>

.about-us {
  background-color: #fff;
  padding-top: 20px;
  padding-bottom: 20px;
  img {
    float: left;
    width: 520px;
    height: 290px;
  }
  .about-detail-content {
    float: right;
    width: 600px;
    text-align: left;
    line-height: 25px;
    font-size: 14px;
    > p {
      margin: 0 0 20px 0;
    }
    ul {
      li {
        font-weight: bold;
        list-style: none;
        span {
          color: red;
        }
        p {
          display: inline-block;
        }
      }
    }
  }
}
.about-contact{
  background-color: #F6F6F6;
  overflow: hidden;
  img{
    float: left;
  }
  .contact-detail{
    float: left;
    margin-left: 80px;
    text-align: left;
    font-size: 16px;
    p{
      margin-bottom: 12px;
    }
  }
}
</style>
