import React from 'react';

import Banner from '../components/Banner'
import HowItWorks from '../components/HowItWorks'

import bgImage from "../assets/img/about.jpg"
import image1 from "../assets/img/1.png"
import image2 from "../assets/img/2.png"
import image3 from "../assets/img/3.png"
import image4 from "../assets/img/4.png"
import image5 from "../assets/img/5.png"
import image6 from "../assets/img/6.png"
import productImage from "../assets/img/product_magazin_image2.jpg"


const howitworksData = [
  {
    index: "1", 
    image: image1,
    title: "1. Products & Services",
    description: "Capture PRODUCTS & SERVICES you provide"
  },
  {
    index: "2", 
    image: image2,
    title: "2. Quantity / Volume",
    description: "Capture your production volumes be it weekly, monthly etc."
  },
  {
    index: "3", 
    image: image3,
    title: "3. Timelines",
    description: "Provide Timelines your products will be produced related to the Volumes"
  },
  {
    index: "4", 
    image: image4,
    title: "4. Products you consume",
    description: "Add what you CONSUME as well for reverse matching"
  },
  {
    index: "5", 
    image: image5,
    title: "5. Match Making",
    description: "Our ANALYTICS will match you with other BUSINESSES by product, volumes, timelines and location"
  },
  {
    index: "6", 
    image: image6,
    title: "6. Sales",
    description: "You will then get potential SALES. Send sample products for quality testing"
  }
]


class AboutUsPage extends React.Component {
  render() {
    return ( 
      <div>
        <Banner
          bgImage = {bgImage}
          title = {'About Us'}
        />
            <section class="how_it_works">
              <div class="container">
                <div class="heading">How it works</div>
                <div class="row"> 
                  {howitworksData.map((howitworksItem, howitworksKey) => {
                    return (
                      <HowItWorks
                        index = {howitworksItem.index}
                        image = {howitworksItem.image}
                        title = {howitworksItem.title}
                        description = {howitworksItem.description}
                      />
                    );}                      
                  )}     
                </div>
                <p class="indus">We have a sophisticated algorithm which will match you to other businesses by products, services, quantity, timelines & location to generate you LEADS & A SALE www.ManufacturingEzyFind.co.za <span>Industrial 4.0</span></p>
              </div>
            </section>

            <section class="about_us">
              <div class="container">
                <div class="about_part">
                  <div class="row">
                    <div class="col-md-4">
                      <div class="about_image"><img src={productImage} alt=""/></div>
                    </div>
                    <div class="col-md-8">
                      <h2>simply dummy text simply dummy text</h2>
                      <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. </p>
                      <p>But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. </p>
                    </div>
                  </div>
                </div>
                <div class="about_content">
                  <h2>The standard Lorem Ipsum passage </h2>
                  <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, </p>
                  <p>sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, </p>

                  <h3>The standard Lorem Ipsum passage </h3>
                  <ul>
                    <li>Quis autem vel eum iure</li>
                    <li>Quis autem vel eum iure</li>
                    <li>Quis autem vel eum iure</li>
                  </ul>
                  <h2>The standard Lorem Ipsum passage</h2>
                  <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, </p>
                  <p>sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, </p>
                  <ul>
                    <li>Quis autem vel eum iure</li>
                    <li>Quis autem vel eum iure</li>
                    <li>Quis autem vel eum iure</li>
                  </ul>
                  <h2>The standard Lorem Ipsum passage</h2>
                  <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, </p>
                  <p>sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, </p>
                  <h3>The standard Lorem Ipsum passage </h3>
                  <p>sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, </p>
                  <ul>
                    <li>Quis autem vel eum iure</li>
                    <li>Quis autem vel eum iure</li>
                    <li>Quis autem vel eum iure</li>
                  </ul>
                  <h3>The standard Lorem Ipsum passage </h3>
                  <p>sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, </p>
                  <h3>The standard Lorem Ipsum passage </h3>
                  <p>sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, </p>
                  <h2>The standard Lorem Ipsum passage </h2>
                  <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, </p>
                  <p>sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, </p>
                  <p>On the other hand, we denounce with righteous indignation and dislike men who are so beguiled and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided. But in certain circumstances and owing to the claims of duty or the obligations of business it will frequently occur that pleasures have to be repudiated and annoyances accepted. The wise man therefore always holds in these matters to this principle of selection: he rejects pleasures to secure other greater pleasures, or else he endures pains to avoid worse pains.</p>
                </div>
              </div>
            </section>
          </div>
        );
    }
}

export default AboutUsPage;
